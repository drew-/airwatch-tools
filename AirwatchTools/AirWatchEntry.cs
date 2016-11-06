using System.ComponentModel;

namespace AirwatchTools {
    public class AirWatchEntry : INotifyPropertyChanged {
        #region Private Members
        //PRIVATE MEMBERS
        private string username;
        private string password;
        private string active;
        private string securityType;
        private string enableDeviceStaging;
        private string preReegisterForVpp;
        private string emailUserName;
        private string emailAddress;
        private string emailPassword;
        private string userPrincipalName;
        private string firstName;
        private string middleName;
        private string lastName;
        private string groupID;
        private string authorizedGroupIDs;
        private string enrollmentOrganizationGroup;
        private string domain;
        private string phoneNumber;
        private string mobilePhone;
        private string department;
        private string userCategory;
        private string userRole;
        private string userMessageType;
        private string userMessageSubject;
        private string userMessageBody;
        private string employeeIdentifier;
        private string costCenter;
        private string managerDn;
        private string deviceGroupID;
        private string deviceFriendlyName;
        private string deviceOwnership;
        private string deviceMessageType;
        private string deviceUDID;
        private string deviceIMEI;
        private string deviceSIM;
        private string deviceAssetNumber;
        private string deviceSerialNumber;
        private string devicePlatform;
        private string deviceModel;
        private string deviceOS;
        private string deviceOEM;
        private string tags;
        private string customAttributeName1;
        private string customAttributeName2;
        private string customAttributeName3;
        #endregion

        #region Getters andSetters
        //GETERS AND SETTERS
        public string Username {
            get { return username; }
            set {
                if(username != value) {
                    username = value;
                    NotifyPropertyChanged("Username");
                }
            }
        }

        public string Password {
            get { return password; }
            set {
                if (password != value) {
                    password = value;
                    NotifyPropertyChanged("Password");
                }
            }
        }

        public string Active{
            get { return active; }
            set {
                if (active != value) {
                    active = value;
                    NotifyPropertyChanged("Active");
                }
            }
        }

        public string SecurityType {
            get { return securityType; }
            set {
                if (securityType != value) {
                    securityType = value;
                    NotifyPropertyChanged("SecurityType");
                }
            }
        }

        public string EnableDeviceStaging {
            get { return enableDeviceStaging; }
            set {
                if (enableDeviceStaging != value) {
                    enableDeviceStaging = value;
                    NotifyPropertyChanged("EnableDeviceStaging");
                }
            }
        }

        public string PreReegisterForVpp {
            get { return preReegisterForVpp; }
            set {
                if (preReegisterForVpp != value) {
                    preReegisterForVpp = value;
                    NotifyPropertyChanged("PreReegisterForVpp");
                }
            }
        }

        public string EmailUserName {
            get { return emailUserName; }
            set {
                if (emailUserName != value) {
                    emailUserName = value;
                    NotifyPropertyChanged("EmailUserName");
                }
            }
        }

        public string EmailAddress {
            get { return emailAddress; }
            set {
                if (emailAddress != value) {
                    emailAddress = value;
                    NotifyPropertyChanged("EmailAddress");
                }
            }
        }

        public string EmailPassword {
            get { return emailPassword; }
            set {
                if (emailPassword != value) {
                    emailPassword = value;
                    NotifyPropertyChanged("EmailPassword");
                }
            }
        }

        public string UserPrincipalName {
            get { return emailPassword; }
            set {
                if (userPrincipalName != value) {
                    userPrincipalName = value;
                    NotifyPropertyChanged("UserPrincipalName");
                }
            }
        }

        public string FirstName {
            get { return firstName; }
            set {
                if (firstName != value) {
                    firstName = value;
                    NotifyPropertyChanged("FirstName");
                }
            }
        }

        public string MiddleName {
            get { return emailPassword; }
            set {
                if (middleName != value) {
                    middleName = value;
                    NotifyPropertyChanged("MiddleName");
                }
            }
        }

        public string LastName {
            get { return lastName; }
            set {
                if (lastName != value) {
                    lastName = value;
                    NotifyPropertyChanged("LastName");
                }
            }
        }

        public string GroupID {
            get { return groupID; }
            set {
                if (groupID != value) {
                    groupID = value;
                    NotifyPropertyChanged("GroupID");
                }
            }
        }

        public string AuthorizedGroupIDs {
            get { return authorizedGroupIDs; }
            set {
                if (authorizedGroupIDs != value) {
                    authorizedGroupIDs = value;
                    NotifyPropertyChanged("AuthorizedGroupIDs");
                }
            }
        }

        public string EnrollmentOrganizationGroup {
            get { return enrollmentOrganizationGroup; }
            set {
                if (enrollmentOrganizationGroup != value) {
                    enrollmentOrganizationGroup = value;
                    NotifyPropertyChanged("EnrollmentOrganizationGroup");
                }
            }
        }

        public string Domain {
            get { return domain; }
            set {
                if (domain != value) {
                    domain = value;
                    NotifyPropertyChanged("Domain");
                }
            }
        }

        public string PhoneNumber {
            get { return phoneNumber; }
            set {
                if (phoneNumber != value) {
                    phoneNumber = value;
                    NotifyPropertyChanged("PhoneNumber");
                }
            }
        }

        public string MobilePhone {
            get { return mobilePhone; }
            set {
                if (mobilePhone != value) {
                    mobilePhone = value;
                    NotifyPropertyChanged("MobilePhone");
                }
            }
        }

        public string Department {
            get { return department; }
            set {
                if (department != value) {
                    department = value;
                    NotifyPropertyChanged("Department");
                }
            }
        }

        public string UserCategory {
            get { return userCategory; }
            set {
                if (userCategory != value) {
                    userCategory = value;
                    NotifyPropertyChanged("UserCategory");
                }
            }
        }

        public string UserRole {
            get { return userRole; }
            set {
                if (userRole != value) {
                    userRole = value;
                    NotifyPropertyChanged("UserRole");
                }
            }
        }

        public string UserMessageType {
            get { return userMessageType; }
            set {
                if (userMessageType != value) {
                    userMessageType = value;
                    NotifyPropertyChanged("UserMessageType");
                }
            }
        }

        public string UserMessageSubject {
            get { return userMessageSubject; }
            set {
                if (userMessageSubject != value) {
                    userMessageSubject = value;
                    NotifyPropertyChanged("UserMessageSubject");
                }
            }
        }

        public string UserMessageBody {
            get { return userMessageBody; }
            set {
                if (userMessageBody != value) {
                    userMessageBody = value;
                    NotifyPropertyChanged("UserMessageBody");
                }
            }
        }

        public string EmployeeIdentifier {
            get { return employeeIdentifier; }
            set {
                if (employeeIdentifier != value) {
                    employeeIdentifier = value;
                    NotifyPropertyChanged("EmployeeIdentifier");
                }
            }
        }

        public string CostCenter {
            get { return costCenter; }
            set {
                if (costCenter != value) {
                    costCenter= value;
                    NotifyPropertyChanged("CostCenter");
                }
            }
        }

        public string ManagerDn {
            get { return managerDn; }
            set {
                if (managerDn != value) {
                    managerDn = value;
                    NotifyPropertyChanged("ManagerDn");
                }
            }
        }

        public string DeviceGroupID {
            get { return deviceGroupID; }
            set {
                if (deviceGroupID != value) {
                    deviceGroupID = value;
                    NotifyPropertyChanged("DeviceGroupID");
                }
            }
        }

        public string DeviceFriendlyName {
            get { return deviceFriendlyName; }
            set {
                if (deviceFriendlyName != value) {
                    deviceFriendlyName = value;
                    NotifyPropertyChanged("DeviceFriendlyName");
                }
            }
        }

        public string DeviceOwnership {
            get { return deviceOwnership; }
            set {
                if (deviceOwnership != value) {
                    deviceOwnership = value;
                    NotifyPropertyChanged("DeviceOwnership");
                }
            }
        }

        public string DeviceMessageType {
            get { return deviceMessageType; }
            set {
                if (deviceMessageType != value) {
                    deviceMessageType = value;
                    NotifyPropertyChanged("DeviceMessageType");
                }
            }
        }

        public string DeviceUDID {
            get { return deviceUDID; }
            set {
                if (deviceUDID != value) {
                    deviceUDID = value;
                    NotifyPropertyChanged("DeviceUDID");
                }
            }
        }

        public string DeviceIMEI {
            get { return deviceIMEI; }
            set {
                if (deviceIMEI != value) {
                    deviceIMEI = value;
                    NotifyPropertyChanged("DeviceIMEI");
                }
            }
        }

        public string DeviceSIM {
            get { return deviceSIM; }
            set {
                if (deviceSIM != value) {
                    deviceSIM = value;
                    NotifyPropertyChanged("DeviceSIM");
                }
            }
        }

        public string DeviceAssetNumber {
            get { return deviceAssetNumber; }
            set {
                if (deviceAssetNumber != value) {
                    deviceAssetNumber = value;
                    NotifyPropertyChanged("DeviceAssetNumber");
                }
            }
        }

        public string DeviceSerialNumber {
            get { return deviceSerialNumber; }
            set {
                if (deviceSerialNumber != value) {
                    deviceSerialNumber = value;
                    NotifyPropertyChanged("DeviceSerialNumber");
                }
            }
        }

        public string DevicePlatform {
            get { return devicePlatform; }
            set {
                if (devicePlatform != value) {
                    devicePlatform = value;
                    NotifyPropertyChanged("DevicePlatform");
                }
            }
        }

        public string DeviceModel {
            get { return deviceModel; }
            set {
                if (deviceModel != value) {
                    deviceModel = value;
                    NotifyPropertyChanged("DeviceModel");
                }
            }
        }

        public string DeviceOS {
            get { return deviceOS; }
            set {
                if (deviceOS != value) {
                    deviceOS = value;
                    NotifyPropertyChanged("DeviceOS");
                }
            }
        }

        public string DeviceOEM {
            get { return deviceGroupID; }
            set {
                if (deviceOEM != value) {
                    deviceOEM = value;
                    NotifyPropertyChanged("DeviceOEM");
                }
            }
        }

        public string Tags {
            get { return tags; }
            set {
                if (tags != value) {
                    tags = value;
                    NotifyPropertyChanged("Tags");
                }
            }
        }

        public string CustomAttributeName1 {
            get { return customAttributeName1; }
            set {
                if (customAttributeName1 != value) {
                    customAttributeName1 = value;
                    NotifyPropertyChanged("CustomAttributeName1");
                }
            }
        }

        public string CustomAttributeName2 {
            get { return deviceGroupID; }
            set {
                if (customAttributeName2 != value) {
                    customAttributeName2 = value;
                    NotifyPropertyChanged("CustomAttributeName2");
                }
            }
        }

        public string CustomAttributeName3 {
            get { return customAttributeName3; }
            set {
                if (customAttributeName3 != value) {
                    customAttributeName3 = value;
                    NotifyPropertyChanged("CustomAttributeName3");
                }
            }
        }
        #endregion

        #region Interface Inplementations
        //INTERFACE IMPLIMENTATIONS
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propName) {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
        #endregion
    }
}