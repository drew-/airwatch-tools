using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.IO;

namespace AirwatchTools {
    class CsvBuilder {
        private string fileName;
        private ObservableCollection<AirWatchEntry> entries;
        private StringBuilder output = new StringBuilder();

        public CsvBuilder(string fileName, ObservableCollection<AirWatchEntry> entries) {
            this.fileName = fileName;
            this.entries = entries;

            HeaderBuilder buidler = new HeaderBuilder();
            string header = buidler.BuildHeader();

            output.Append(header);

            CreateCsvFile(header);
        }

        private void CreateCsvFile(string header) {
            foreach (AirWatchEntry e in entries) {
                output.Append(Environment.NewLine);

                output.Append(RowBuilder(e));
            }

            using (FileStream stream = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite)) {
                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8)) {
                    writer.Write(output);
                }
            }
        }

        private string RowBuilder(AirWatchEntry e) {
            StringBuilder builder = new StringBuilder();

            foreach (var prop in e.GetType().GetProperties()) {

                bool didMatch = false;

                

                if (!String.IsNullOrEmpty((string)prop.GetValue(e, null))) {
                    builder.Append((string)prop.GetValue(e, null));
                    builder.Append(",");

                    didMatch = true;
                }
                
                if (didMatch == false)
                    builder.Append(",");
            }

            return builder.ToString();
        }
    }
}
