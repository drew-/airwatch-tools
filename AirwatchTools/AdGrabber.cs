using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Windows;

namespace AirwatchTools {
    class AdGrabber {
        ObservableCollection<AirWatchEntry> entries = new ObservableCollection<AirWatchEntry>();

        //private const string domainPath = @"LDAP://bowen.lcl";
        private const string domainPath = @"LDAP://andy.local";

        public ObservableCollection<AirWatchEntry> GetUserInfo(List<string> userNames) {
            try {
                DirectoryEntry searchRoot = new DirectoryEntry(domainPath);

                DirectorySearcher search = new DirectorySearcher(searchRoot);

                search.PropertiesToLoad.Add("mail");
                search.PropertiesToLoad.Add("givenName");
                search.PropertiesToLoad.Add("sn");

                int index = 0;

                foreach (var s in userNames) {
                    search.Filter = "sAMAccountName=" + userNames[index];

                    SearchResult result = search.FindOne();

                    DirectoryEntry de = new DirectoryEntry();
                    de = result.GetDirectoryEntry();

                    RequiredlFields requiredFields = new RequiredlFields();
                    List<string> requiredFiledsList = requiredFields.PopulateUserInfo();

                    AirWatchEntry entry = new AirWatchEntry();

                    foreach (string f in requiredFiledsList) {
                        switch (f) {
                            case "Username*":
                                entry.Username = userNames[index];
                                break;
                            case "Active":
                                entry.Active = "1";
                                break;
                            case "Security Type*":
                                entry.SecurityType = "Directory";
                                break;
                            case "Email Username":
                                entry.EmailUserName = de.Properties["userPrincipalName"][0].ToString();
                                break;
                            case "Email Address":
                                entry.EmailAddress = de.Properties["mail"][0].ToString();
                                break;
                            case "First Name*":
                                entry.FirstName = de.Properties["givenName"][0].ToString();
                                break;
                            case "Last Name*":
                                entry.LastName = de.Properties["sn"][0].ToString();
                                break;
                            case "GroupID*":
                                entry.GroupID = "TheO9164";
                                break;
                            case "Authorized GroupIDs":
                                entry.AuthorizedGroupIDs = "TheO9166";
                                break;
                            case "Enrollment Organization Group":
                                entry.EnrollmentOrganizationGroup = "TheO9166";
                                break;
                            case "Domain*":
                                entry.Domain = "bowen.lcl";
                                break;
                            case "Device Friendly Name":
                                entry.DeviceFriendlyName = "?WT";
                                break;
                            case "Device Serial Number":
                                break;
                            case "Device Platform":
                                entry.DevicePlatform = "Windows Desktop";
                                break;
                        }
                    }

                    entries.Add(entry);

                    index++;
                }
            } catch (Exception e) {
                MessageBox.Show(e.ToString());
            }

            return entries;
        }
    }

    public class RequiredlFields {
        public string[] Fields = new string[] { "Username*", "Active", "Security Type*", "Email Username", "Email Address*", "First Name*", "Last Name*", "GroupID*", "Authorized GroupIDs",
                                                       "Enrollment Organization Group", "Domain*", "Device Friendly Name", "Device Serial Number",  "Device Platform" };
        public List<string> PopulateUserInfo() {
            List<string> fields = new List<string>();

            int index = 0;

            foreach (string s in Fields) {
                fields.Add(Fields[index]);

                index++;
            }

            return fields;
        }
    }
}
