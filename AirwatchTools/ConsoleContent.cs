using System.ComponentModel;
using System.Collections.ObjectModel;

namespace AirwatchTools {
    class ConsoleContent {
        string consoleInput = string.Empty;

        ObservableCollection<string> consoleOutput = new ObservableCollection<string>() { "AirWolf Agent Started..." };

        public string ConsoleInput {
            get {
                return consoleInput;
            }
            set {
                consoleInput = value;
                OnPropertyChanged("ConsoleInput");
            }
        }

        public ObservableCollection<string> ConsoleOutput {
            get {
                return consoleOutput;
            }
            set {
                consoleOutput = value;
                OnPropertyChanged("ConsoleOutput");
            }
        }

        public void RunCommand() {
            ConsoleOutput.Add(ConsoleInput);
            // do your stuff here.
            ConsoleInput = string.Empty;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string propertyName) {
            if (null != PropertyChanged)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
