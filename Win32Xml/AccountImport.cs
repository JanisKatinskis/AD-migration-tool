using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Windows.Forms;



namespace Win32Xml
{
    class AccountImport
    {

        /// <summary>
        /// This function reads user info from XML file and gives it to MakePrincipalUser() function to create users.
        /// </summary>
        /// <param name="filePath">filepath to folder where the XML file is located</param>
        public static void ReadUsers(string filePath)
        {

            try
            {

                // Loads the XML document from the given filepath.
                XDocument doc = XDocument.Load(filePath);

                // Variable that contains user information queried from the XML file
                var item = from q in doc.Descendants("User")
                           select new
                           {
                               AllowReversiblePasswordEncryption = q.Element("AllowReversiblePasswordEncryption").Value,
                               DelegationPermitted = q.Element("DelegationPermitted").Value,
                               Description = q.Element("Description").Value,
                               DisplayName = q.Element("DisplayName").Value,
                               DistinguishedName = q.Element("DistinguishedName").Value,
                               EmailAddress = q.Element("EmailAddress").Value,
                               EmployeeId = q.Element("EmployeeId").Value,
                               Enabled = q.Element("Enabled").Value,
                               GivenName = q.Element("GivenName").Value,
                               HomeDirectory = q.Element("HomeDirectory").Value,
                               HomeDrive = q.Element("HomeDrive").Value,
                               MiddleName = q.Element("MiddleName").Value,
                               Name = q.Element("Name").Value,
                               PasswordNeverExpires = q.Element("PasswordNeverExpires").Value,
                               PasswordNotRequired = q.Element("PasswordNotRequired").Value,
                               PermittedWorkstations = q.Element("PermittedWorkstations").Value,
                               SamAccountName = q.Element("SamAccountName").Value,
                               ScriptPath = q.Element("ScriptPath").Value,
                               SmartcardLogonRequired = q.Element("SmartcardLogonRequired").Value,
                               Surname = q.Element("Surname").Value,
                               UserCannotChangePassword = q.Element("UserCannotChangePassword").Value,
                               UserPrincipalName = q.Element("UserPrincipalName").Value,
                               VoiceTelephoneNumber = q.Element("VoiceTelephoneNumber").Value
                           };

                // Reads the info from each group and then relays it to function that is responsible for
                // creating users and adding them to the Active Directory.
                foreach (var x in item)
                {
                    MakePrincipalUser("123!@#QWE", x.AllowReversiblePasswordEncryption, x.DelegationPermitted, 
                        x.Description, x.DisplayName, x.EmailAddress, x.EmployeeId, x.Enabled, 
                        x.GivenName, x.HomeDirectory, x.HomeDrive, x.MiddleName, x.Name, 
                        x.PasswordNeverExpires, x.PasswordNotRequired, x.PermittedWorkstations, 
                        x.SamAccountName, x.ScriptPath, x.SmartcardLogonRequired, x.Surname, 
                        x.UserCannotChangePassword, x.UserPrincipalName, x.VoiceTelephoneNumber);
                }

            }

            // Error handler
            catch (Exception e)
            {
                MessageBox.Show("An error occurred. {0}", e.Message);
            }
        }

        /// <summary>
        /// This function reads group info from XML file and gives it to MakePrincipalGroup() function to create groups.
        /// </summary>
        /// <param name="filePath">filepath to folder where the XML file is located</param>
        public static void ReadGroups(string filePath)
        {

            try
            {

                // Loads the XML document from the given filepath.
                XDocument doc = XDocument.Load(filePath);

                // Variable that contains group information queried from the XML file
                var item = from q in doc.Descendants("Group")
                           select new
                           {
                               Context = q.Element("Context").Value,
                               ContextType = q.Element("ContextType").Value,
                               Description = q.Element("Description").Value,
                               DisplayName = q.Element("DisplayName").Value,
                               DistinguishedName = q.Element("DistinguishedName").Value,
                               GroupScope = q.Element("GroupScope").Value,
                               Guid = q.Element("Guid").Value,
                               IsSecurityGroup = q.Element("IsSecurityGroup").Value,
                               Name = q.Element("Name").Value,
                               SamAccountName = q.Element("SamAccountName").Value,
                               Sid = q.Element("Sid").Value,
                               StructuralObjectClass = q.Element("StructuralObjectClass").Value,
                               UserPrincipalName = q.Element("UserPrincipalName").Value
                           };

                // Reads the info from each group and then relays it to function that is responsible for
                // creating user groups and adding them to the Active Directory.
                foreach (var x in item)
                {
                    MakePrincipalGroup(x.Description, x.DisplayName, x.DistinguishedName,
                        x.GroupScope, x.IsSecurityGroup, x.Name, x.SamAccountName, x.UserPrincipalName);
                }
            }

            // Error handler
            catch (Exception e)
            {
                MessageBox.Show("An error occurred. {0}", e.Message);
            }
        }


        /// <summary>
        /// This function reads user-group relational info and sends it to AddMemberToGroup() to add users to security groups.
        /// </summary>
        /// <param name="folderPath">filepath to folder where the XML file is located</param>
        public static void UsersToGroups(string folderPath)
        {

            try
            {

                // Loads the XML document from the given filepath.
                XDocument doc = XDocument.Load(folderPath);

                // Variable that contains user information queried from the XML file
                var item = from q in doc.Descendants("User")
                           select new
                           {
                               Username = q.Element("Username").Value,
                               GroupName = q.Element("GroupName").Value
                           };

                // For each queried user the AddMemberToGroup function is executed that adds user to a group.
                foreach (var x in item)
                {
                    AddMemberToGroup(x.Username, x.GroupName);
                }

            }

            // Error handler
            catch (Exception e)
            {
                MessageBox.Show("An error occurred. {0}", e.Message);
            }

        }

        /// <summary>
        /// This function creates new user and adds it to Active Directory.
        /// The function arguments are user parameters from the XML file.
        /// </summary>
        public static void MakePrincipalUser(
            string password,
            string AllowReversiblePasswordEncryption,
            string DelegationPermitted,
            string Description,
            string DisplayName,
            string EmailAddress,
            string EmployeeId,
            string Enabled,
            string GivenName,
            string HomeDirectory,
            string HomeDrive,
            string MiddleName,
            string Name,
            string PasswordNeverExpires,
            string PasswordNotRequired,
            string PermittedWorkstations,
            string SamAccountName,
            string ScriptPath,
            string SmartcardLogonRequired,
            string Surname,
            string UserCannotChangePassword,
            string UserPrincipalName,
            string VoiceTelephoneNumber)
        {
            try
            {

                // PrincipalContext constructor
                PrincipalContext context = new PrincipalContext(ContextType.Machine);

                // UserPrincipal constructor
                UserPrincipal user = new UserPrincipal(context);

                // Sets username
                user.Name = Name;

                // Sets the initial password.
                user.SetPassword(password);

                /************************************************************************
                    The following actions add info to user's properties.
                    N.B. It is not possible to set some properties either because they are
                        system-created and thus read-only or they cannot be set (suspectedly)
                        because of a bug in the .NET framework that disallows to set them 
                        (as far as I have tried to). The properties that cannot be set are 
                        comented out with the reason why besides them.
                        They are left in the code for a possibility of a bugfix in the framework
                        or some possible workaround.
                ************************************************************************/
                //user.AccountExpirationDate = Convert.ToDateTime(AccountExpirationDate); // String is not recognised as vaild date-time. Seemingly irrevelant, since this property isn't really used.
                //user.AccountLockoutTime = AccountLockoutTime; // read only
                //user.AdvancedSearchFilter = AdvancedSearchFilter; // read only
                user.AllowReversiblePasswordEncryption = Convert.ToBoolean(AllowReversiblePasswordEncryption);
                //user.BadLogonCount = BadLogonCount; // read only
                //user.Certificates = Certificates; // read only
                //user.Context = Context; // read only
                //user.ContextType = ContextType; // ContextType is Domain
                user.DelegationPermitted = Convert.ToBoolean(DelegationPermitted);
                user.Description = Description;
                user.DisplayName = DisplayName;
                //user.DistinguishedName = DistinguishedName; // read only
                //user.EmailAddress = EmailAddress.ToString(); // "Object reference not set to an instance of an object" error. Apparently a bug in the framework.
                //user.EmployeeId = EmployeeId.ToString(); // "Object reference not set to an instance of an object" error.
                user.Enabled = Convert.ToBoolean(Enabled);
                //user.GivenName = GivenName; // "Object reference not set to an instance of an object" error.
                //user.Guid = Guid; // read only
                user.HomeDirectory = HomeDirectory;
                user.HomeDrive = HomeDrive;
                //user.LastBadPasswordAttempt = LastBadPasswordAttempt; // read only
                //user.LastLogon = LastLogon; // read only
                //user.LastPasswordSet = LastPasswordSet; // read only
                //user.MiddleName = MiddleName; // "Object reference not set to an instance of an object" error.
                user.PasswordNeverExpires = Convert.ToBoolean(PasswordNeverExpires);
                user.PasswordNotRequired = Convert.ToBoolean(PasswordNotRequired);
                //user.PermittedLogonTimes = new byte[Convert.ToByte(PermittedLogonTimes)]; // Integer range error. Irrelevant, since it has seemingly infinite logon times.
                //user.PermittedWorkstations = PermittedWorkstations; // read only
                user.SamAccountName = SamAccountName; 
                user.ScriptPath = ScriptPath;
                //user.Sid = Sid; // read only
                user.SmartcardLogonRequired = Convert.ToBoolean(SmartcardLogonRequired);
                //user.StructuralObjectClass = StructuralObjectClass; // read only
                //user.Surname = Surname; // "Object reference not set to an instance of an object" error.
                user.UserCannotChangePassword = Convert.ToBoolean(UserCannotChangePassword);
                //user.UserPrincipalName = UserPrincipalName; // "Object reference not set to an instance of an object" error.
                //user.VoiceTelephoneNumber = VoiceTelephoneNumber; // "Object reference not set to an instance of an object" error.

                // Saves user account
                user.Save();

                // GroupPrincipal constructor. Creates GroupPrincipal with identity "Users"
                GroupPrincipal groupPrinc = GroupPrincipal.FindByIdentity(context, "Users");

                // Adds user to "Users" group.
                groupPrinc.Members.Add(user);

                // Saves changes to the group.
                groupPrinc.Save();

                // If there is no home directory info, this step is skipped
                if (HomeDirectory != String.Empty)
                {
                    // Creates home directory for the user.
                    CreateHomeFolder(HomeDirectory, HomeDrive);
                }

                // Expires the password so the user will have to change it on next logon.
                user.ExpirePasswordNow();

                // Checks if the "Generate Report" checkbox is ticked
                if (Global.generateReport == true)
                {
                    // Adds report entry about the current user
                    Utility.addToReportFile("User \"" + SamAccountName + "\" created successfully");
                }

                return;

            }

            // Error handler
            catch (Exception e)
            {
                // Checks if the "Generate Report" checkbox is ticked
                if (Global.generateReport == true)
                {
                    // Adds report entry if there is an error creating user
                    Utility.addToReportFile("Error creating user \"" + SamAccountName + "\": " + e.Message);
                }
            }

        }

        /// <summary>
        /// This function creates new group and adds it to Active Directory.
        /// The function arguments are group parameters from the XML file.
        /// </summary>
        public static void MakePrincipalGroup(
            string Description,
            string DisplayName,
            string DistinguishedName,
            string varGroupScope,
            string IsSecurityGroup,
            string Name,
            string SamAccountName,
            string UserPrincipalName)
        {
            try
            {

                // PrincipalContext constructor
                PrincipalContext context = new PrincipalContext(ContextType.Domain);

                // GroupPrincipal constructor
                GroupPrincipal group = new GroupPrincipal(context, SamAccountName);

                
                
                /***************************************************
                    The following actions set group's properties 
                ***************************************************/

                // Sets description of the group. Checks if not empty to avoid unnecessary errors.
                if (Description != string.Empty)
                {
                    group.Description = Description;
                }

                group.DisplayName = DisplayName;

                // Sets group's Scope wheter it is Local, Global, or Universal.
                switch (varGroupScope)
                {
                    case "Local": Console.WriteLine("Local scope"); group.GroupScope = GroupScope.Local; break;
                    case "Global": Console.WriteLine("Global scope"); group.GroupScope = GroupScope.Global; break;
                    case "Universal": Console.WriteLine("Universal scope"); group.GroupScope = GroupScope.Universal; break;
                }

                group.IsSecurityGroup = Convert.ToBoolean(IsSecurityGroup);
                group.Name = Name;
                group.SamAccountName = SamAccountName;

                // Sets UserPrincipalName of the group. Checks if not empty to avoid unnecessary errors.
                if (UserPrincipalName != string.Empty)
                {
                    group.UserPrincipalName = UserPrincipalName;
                }

                // Saves the newly created group
                group.Save();

                // Checks if the "Generate Report" checkbox is ticked
                if (Global.generateReport == true)
                {
                    // Adds report entry about the current group
                    Utility.addToReportFile("Group \"" + SamAccountName + "\" created successfully");
                }

            }

            // Error handler
            catch (Exception e)
            {
                // Checks if the "Generate Report" checkbox is ticked
                if (Global.generateReport == true)
                {
                    // Adds report entry if there is an error creating user
                    Utility.addToReportFile("Error creating group \"" + SamAccountName + "\": " + e.Message);
                }
            }

        }

        /// <summary>
        /// This function adds Active Directory user (by its SamAccountname) to a groups (by group's SamAccountName)
        /// </summary>
        /// <param name="userName">User SamAccountName parameter</param>
        /// <param name="groupName">Group SamAccountName parameter</param>
        public static void AddMemberToGroup(string userName, string groupName)
        {
            try
            {

                // PrincipalContext constructor
                PrincipalContext AD = new PrincipalContext(ContextType.Domain);

                // GroupPrincipal constructor. Creates GroupPricipal object to which a new group will be added.
                GroupPrincipal group = GroupPrincipal.FindByIdentity(AD, IdentityType.SamAccountName, groupName);

                // Adds user (by SamAccountName) to the group.
                group.Members.Add(AD, IdentityType.SamAccountName, userName);

                // Saves changes
                group.Save();

                // Checks if the "Generate Report" checkbox is ticked
                if (Global.generateReport == true)
                {
                    // Adds report entry about the current group
                    Utility.addToReportFile("User \"" + userName + "\" added to group \"" + groupName + "\" successfully");
                }


            }

            // Error handler
            catch (Exception e)
            {
                // Checks if the "Generate Report" checkbox is ticked
                if (Global.generateReport == true)
                {
                    // Adds report entry if there is an error creating user
                    Utility.addToReportFile("Error adding user \"" + userName + "\" to group \"" + groupName + "\": " + e.Message);
                }
            }
        }


        /// <summary>
        /// Creates home folder for the user.
        /// </summary>
        /// <param name="HomeDirectory">HomeDirectory parameter from the Active Directory info file</param>
        /// <param name="HomeDrive">HomeDrive parameter from the Active Directory info file</param>
        public static void CreateHomeFolder(string HomeDirectory, string HomeDrive)
        {
            string homeFolder = HomeDirectory;
            for (int i = 0; i < 3; i++)
            {
                homeFolder = homeFolder.Substring(homeFolder.IndexOf('\\') + 1);
            }

            homeFolder = HomeDrive + "\\" + homeFolder;

            Directory.CreateDirectory(homeFolder);

        }

        /// <summary>
        /// This function generetes log file that will contain report of imported users, groups, and members of groups.
        /// The report file is named after the date of import.
        /// </summary>
        /// <param name="filePath">Path where the file will be saved</param>
        /// <param name="fileName">Name of the file</param>
        public static void generateImportReportFile(string filePath)
        {
            // Sets the path to the report file
            Global.reportFullPath = filePath + "ImportReport_" + DateTime.Today.Date.ToString("dd.MM.yyyy") + ".txt";

            // Creates new report file containing the current date.
            StreamWriter file = new StreamWriter(Global.reportFullPath);

            // Writes the heading of the file in the first line
            file.WriteLine("ACTIVE DIRECTORY IMPORT REPORT " + DateTime.Today.Date.ToString("dd.MM.yyyy"));
            file.WriteLine(String.Empty);

            // Closes the text file
            file.Close();
        }


    }

}
