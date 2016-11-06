using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;

namespace AirwatchTools {
    class AdGrabber {
        ObservableCollection<AirWatchEntry> entries = new ObservableCollection<AirWatchEntry>();

        private string resultMessage;
        private List<string> userNames = new List<string>();

        //private const string domainPath = @"LDAP://bowen.lcl";
        private const string domainPath = @"LDAP://andy.local";

        public AdGrabber(List<string> userNames) {
            this.userNames = userNames;
        }

        public ObservableCollection<AirWatchEntry> GetUserInfo() {
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
                            case "Device Platform":
                                entry.DevicePlatform = "Windows Desktop";
                                break;
                        }
                    }

                    entries.Add(entry);

                    index++;
                }
            } catch (Exception e) {
                resultMessage += e.ToString();   
            }

            return entries;
        }


        public string GetResultMessage() {


            return resultMessage;
        }

        public void GetAccountsFromUserName() {

        }

        public void GetAccountsFromFirstAndLastName(string firstName, string lastName) {
            PrincipalContext context = new PrincipalContext(ContextType.Domain);
            
            UserPrincipal principal = new UserPrincipal(context);
            principal.GivenName = firstName;
            principal.Surname = lastName;

            PrincipalSearcher searcher = new PrincipalSearcher(principal);
            PrincipalSearchResult<Principal> result  = searcher.FindAll();

            foreach(Principal p in result) {
                userNames.Add(p.SamAccountName);
            }
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
