using System.ComponentModel;

namespace AirwatchTools {
    public class AirWatchEntry : INotifyPropertyChanged {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Active { get; set; }
        public string SecurityType { get; set; }
        public string EnableDeviceStaging { get; set; }
        public string PreReegisterForVpp { get; set; }
        public string EmailUserName { get; set; }
        public string EmailAddress { get; set; }
        public string EmailPassword { get; set; }
        public string UserPrincipalName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string GroupID { get; set; }
        public string AuthorizedGroupIDs { get; set; }
        public string EnrollmentOrganizationGroup { get; set; }
        public string Domain { get; set; }
        public string PhoneNumber { get; set; }
        public string MobilePhone { get; set; }
        public string Department { get; set; }
        public string UserCategory { get; set; }
        public string UserRole { get; set; }
        public string UserMessageType { get; set; }
        public string UserMessageSubject { get; set; }
        public string UserMessageBody { get; set; }
        public string EmployeeIdentifier { get; set; }
        public string CostCenter { get; set; }
        public string ManagerDn { get; set; }
        public string DeviceGroupID { get; set; }
        public string DeviceFriendlyName { get; set; }
        public string DeviceOwnership { get; set; }
        public string DeviceMessageType { get; set; }
        public string DeviceUDID { get; set; }
        public string DeviceIMEI { get; set; }
        public string DeviceSIM { get; set; }
        public string DeviceAssetNumber { get; set; }
        public string DeviceSerialNumber { get; set; }
        public string DevicePlatform { get; set; }
        public string DeviceModel { get; set; }
        public string DeviceOS { get; set; }
        public string DeviceOEM { get; set; }
        public string Tags { get; set; }
        public string CustomAttributeName1 { get; set; }
        public string CustomAttributeName2 { get; set; }
        public string CustomAttributeName3 { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
