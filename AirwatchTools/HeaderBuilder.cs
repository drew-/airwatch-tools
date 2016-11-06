using System.Text;

namespace AirwatchTools {
    class HeaderBuilder {
        private StringBuilder builder = new StringBuilder();

        public string BuildHeader() {

            bool isFirstElement = true;

            foreach (string s in AirWatchElements.fields) {
                if (!isFirstElement)
                    builder.Append(",");

                builder.Append(s);

                isFirstElement = false;
            }

            return builder.ToString();
        }
    }
}
