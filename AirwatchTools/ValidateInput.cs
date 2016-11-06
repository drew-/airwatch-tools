using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows;

namespace AirwatchTools {
    class ValidateInput {
        string input;

        public ValidateInput(string input) {
            this.input = input;
        }

        public bool IsValid() {
            bool isValid = false;

            if (Regex.IsMatch(input, @"[\w\s,]+", RegexOptions.IgnoreCase))
                isValid = true;

            return isValid;
        }

        public List<string> GetUserList() {
            List<string> users = new List<string>();

            char[] delimiter = { ',' };

            string[] userArray = input.Split(delimiter);

            foreach (string s in userArray) {
                if (IsCompliantUserName(s))
                    users.Add(s);
                else {
                    string message = "The user " + s + " does not have a valid username.  Do you want to keep this user?";

                    MessageBoxResult result = MessageBox.Show(message, "Error", MessageBoxButton.YesNo);

                    if (result == MessageBoxResult.Yes)
                        users.Add(s);
                }
            }

            return users;
        }

        private bool IsCompliantUserName(string userName) {
            bool isValid = true;

            userName = userName.Trim();

            if (userName.Length != 8) {
                isValid = false;
            }

            int index = 0;

            char[] testArray = userName.ToCharArray();

            for (int i = 0; i < userName.Length; i++) {
                if (index < 4) {
                    if (!Regex.IsMatch(testArray[index].ToString(), @"[A-Za-z]+"))
                        isValid = false;
                } else {
                    if (!Regex.IsMatch(testArray[index].ToString(), @"\d+"))
                        isValid = false;
                }

                index++;
            }

            return isValid;
        }
    }
}
