   M S B A M L   `   `   `  ����H  DAirwatchTools, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:AirwatchToolsAirwatchTools  5   	       AirwatchTools.Visualizer   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:AirwatchTools     5   	     � Title$  
Visualizer��5   	   $	��700��6   $
��1000��6)   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5        $��	dgCsvData��5
      $	��600��6%   $	��Top=�62      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Username��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *
Username+  5      $ Password��6%    67   �� *
Password+  5      $ Active��6%    65   �� *Active+  5      $ SecurityType��6%    6;   �� *SecurityType+  5      $ EnableDeviceStaging��6%    6B   �� *EnableDeviceStaging+  5      $ PreReegisterForVpp��6%    6A   �� *PreReegisterForVpp+  5      $ EmailUserName��6%    6<   �� *EmailUserName+  5      $ EmailAddress��6%    6;   �� *EmailAddress+  5      $ EmailPassword��6%    6<   �� *EmailPassword+  5      $ UserPrincipalName��6%    6@   �� *UserPrincipalName+  5      $ 	FirstName��6%    68   �� *	FirstName+  5      $ 
MiddleName��6%    69   �� *
MiddleName+  5      $ LastName��6%    67   �� *
LastName+  5      $ GroupID��6%    66   �� *	GroupID+  5      $ AuthorizedGroupIDs��6%    6A   �� *AuthorizedGroupIDs+  5      $! EnrollmentOrganizationGroup��6%    6J   �� *EnrollmentOrganizationGroup+  5      $ Domain��6%    65   �� *Domain+  5      $ PhoneNumber��6%    6:   �� *PhoneNumber+  5      $ MobilePhone��6%    6:   �� *MobilePhone+  5      $ 
Department��6%    69   �� *
Department+  5       $ UserCategory��6%    6;   �� *UserCategory+  5!      $ UserRole��6%    67   �� *
UserRole+  5"      $ UserMessageType��6%    6>   �� *UserMessageType+  5#      $ UserMessageSubject��6%    6A   �� *UserMessageSubject+  5$      $ UserMessageBody��6%    6>   �� *UserMessageBody+  5%      $ EmployeeIdentifier��6%    6A   �� *EmployeeIdentifier+  5&      $ 
CostCenter��6%    69   �� *
CostCenter+  5'      $ 	ManagerDn��6%    68   �� *	ManagerDn+  5(      $ DeviceGroupID��6%    6<   �� *DeviceGroupID+  5)      $ DeviceFriendlyName��6%    6A   �� *DeviceFriendlyName+  5*      $ DeviceOwnership��6%    6>   �� *DeviceOwnership+  5+      $ DeviceMessageType��6%    6@   �� *DeviceMessageType+  5,      $ 
DeviceUDID��6%    69   �� *
DeviceUDID+  5-      $ 
DeviceIMEI��6%    69   �� *
DeviceIMEI+  5.      $ 
DeviceSIM ��6%    69   �� *	DeviceSIM+  5/      $ DeviceAssetNumber��6%    6@   �� *DeviceAssetNumber+  50      $ DeviceSerialNumber��6%    6A   �� *DeviceSerialNumber+  51      $ DevicePlatform��6%    6=   �� *DevicePlatform+  52      $ DeviceModel��6%    6:   �� *DeviceModel+  53      $ DeviceOS��6%    67   �� *
DeviceOS+  54      $ 	DeviceOEM��6%    68   �� *	DeviceOEM+  55      $
 Tags��6%    63   �� *Tags+  56      $ CustomAttributeName1��6%    6C   �� *CustomAttributeName1+  57      $ CustomAttributeName2��6%    6C   �� *CustomAttributeName2+  58      $ CustomAttributeName3��6%    6C   �� *CustomAttributeName3+5:      �� 5;   
   -   5         ��Name$ btnEdit��5;      $��Enable Editing��6"   $
��Left=�6N   $��
28,605,0,0q�6i   $	��Top=�6}   $	��100��6�   �� 5<   
   -   5        $ btnScan��5<      $��Scan Mode On ��6"   $
��Left=�6:   $��133,605,0,0q�6U   $	��Top=�6j   $	��100��6�   6�   5=      5>      