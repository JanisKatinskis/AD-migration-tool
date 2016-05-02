using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using System.Xml;
using System.Xml.Linq;
using Microsoft.GroupPolicy;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting...");
            //QueryGroups();
            //QueryUsers();
            //GroupUser();
            //GroupPolicy();
            //CreateDummy("Dummy2016xaxa", "dada", "Test");
            //CreateLocalWindowsAccount("Dummmmy201666xa");
            //ReadGroups("C:\\groups.xml");
            //ReadUsers("C:\\useraccounts.xml");
            //MakeNewUser("512", "TELEKOM\\ojolkina", "", "false", "TELEKOM", "Olga Jolkina", null, "false", "false", "ojolkina", "true", "true", "S-1-5-21-79331101-1830893244-26564730-1048", "1", "OK");
            //QueryPrincipalGroups();
            QueryPrincipalUsers();
            //QueryAsPrincipal();
            //MakePrincipalGroup( null, "DisplayName", "DistinguishedName", "Universal", "true", "AllOne_BPO_SEBTM_User", "AllOne_BPO_SEBTM_User", null);
            //CreateADUser();
            //CreateADGroup("Pirmdiena");
            //MakePrincipalUser("false", "true", null, "Janis-Emils Katinskis", null, "E30129", "true", "Jānis Emīls", null, null, null, "Janis-Emils Katinskis", "true", "true", null, "jkatins0", null, "false", "Katinskis", "false", "jkatins0@ad.lattelekom.biz", null);
            //QueryGroupsMembers();
            //UsersToGroups("C:\\groupsusers.xml");
            //AddMemberToGroup("test group", "jkatins0");

            Console.WriteLine("***ENDED***");
            Console.ReadKey();

        }

        public static void CreateADUser()
        {
            DirectoryEntry localMachine = new DirectoryEntry("WinNT://" +
                Environment.MachineName);
            DirectoryEntry newUser = localMachine.Children.Add("NewADUser1", "user");
            newUser.Invoke("SetPassword", new object[] { "ala" });
            newUser.CommitChanges();
            Console.WriteLine(newUser.Guid.ToString());
            localMachine.Close();
            newUser.Close();
        }

        public static void CreateADGroup(string name)
        {
            if (!DirectoryEntry.Exists("LDAP://CN=" + name + "," + Environment.MachineName))
            {
                try
                {
                    DirectoryEntry entry = new DirectoryEntry("LDAP://" + Environment.MachineName);
                    DirectoryEntry group = entry.Children.Add("CN=" + name, "group");
                    group.Properties["sAmAccountName"].Value = name;
                    group.CommitChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message.ToString());
                }
            }
            else { Console.WriteLine(name + " already exists"); }
        }

        public static void FindGroup()
        {
            DirectoryEntry localMachine = new DirectoryEntry
                ("WinNT://" + Environment.MachineName + ",Computer");
            DirectoryEntry admGroup = localMachine.Children.Find
                ("administrators", "group");
            object members = admGroup.Invoke("members", null);

            /**foreach (object groupMember in (IEnumerable)members)
            {
                DirectoryEntry member = new DirectoryEntry(groupMember);
                Console.WriteLine(member.Name);
            }**/
        }

        public static void QueryGroups() // Queries Win32_Group and exports to XML. Old function
        {
            Console.WriteLine("Executing QueryGroups()...");
            XDocument doc = new XDocument();
            XElement groupList = new XElement("group_list");

            doc.Add(groupList);

            SelectQuery query = new SelectQuery("Win32_Group");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);


            int count = 0;
            foreach (ManagementObject envVar in searcher.Get())
            {
                // Extracts the Win32_Group property information
                groupList.Add(new XElement("Group",
                            new XElement("Caption", envVar["Caption"]),
                            new XElement("Description", envVar["Description"]),
                            new XElement("Domain", envVar["Domain"]),
                            new XElement("InstallDate", envVar["InstallDate"]),
                            new XElement("LocalAccount", envVar["LocalAccount"]),
                            new XElement("Name", envVar["Name"]),
                            new XElement("SID", envVar["SID"]),
                            new XElement("SIDType", envVar["SIDType"]),
                            new XElement("Status", envVar["Status"])
                            ));
                count++;
                if (count >= 20) break; //for testing purposes
            }

            doc.Save("D:\\groups.xml");
            Console.WriteLine("QueryGroups() done!");

        }

        public static void QueryUsers() // Queries Win32_UserAccount and exports to XML. Old function
        {
            Console.WriteLine("Executing QueryUsers()...");
            XDocument doc = new XDocument();
            XElement userList = new XElement("user_list");

            doc.Add(userList);

            SelectQuery query = new SelectQuery("Win32_UserAccount");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);


            int count = 0;
            foreach (ManagementObject envVar in searcher.Get())
            {

                // Extracts the Win32_UserAccount property information
                userList.Add(new XElement("User",
                                new XElement("AccountType", envVar["AccountType"]),
                                new XElement("Caption", envVar["Caption"]),
                                new XElement("Description", envVar["Description"]),
                                new XElement("Disabled", envVar["Disabled"]),
                                new XElement("Domain", envVar["Domain"]),
                                new XElement("FullName", envVar["FullName"]),
                                new XElement("InstallDate", envVar["InstallDate"]),
                                new XElement("LocalAccount", envVar["LocalAccount"]),
                                new XElement("Lockout", envVar["Lockout"]),
                                new XElement("Name", envVar["Name"]),
                                new XElement("PasswordChangeable", envVar["PasswordChangeable"]),
                                new XElement("PasswordExpires", envVar["PasswordExpires"]),
                                new XElement("SID", envVar["SID"]),
                                new XElement("SIDType", envVar["SIDType"]),
                                new XElement("Status", envVar["Status"])
                                ));
                count++;
                //if (count >= 20) break; // For testing purposes
            }

            doc.Save("D:\\useraccounts.xml");
            Console.WriteLine("QueryUsers() done!");

        }

        public static void GroupUser() // Queries Win32_GroupUser for group-user relation.
        {
            Console.WriteLine("Executing GroupUser()...");
            XDocument doc = new XDocument();
            XElement accountList = new XElement("account_list");
            XElement account = new XElement("account");

            doc.Add(accountList);

            //List<String> objectList = new List<String>();

            SelectQuery query = new SelectQuery("Win32_GroupUser");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);

            int count = 0;

            foreach (ManagementObject envVar in searcher.Get())
            {
                accountList.Add(new XElement("account",
                    new XElement("GroupComponent", envVar["GroupComponent"]),
                    new XElement("PartComponent", envVar["PartComponent"])
                    ));

                count++;
                //if (count >= 100) break; // For testing purposes
            }

            doc.Save("D:\\groupuser.xml");
            Console.WriteLine("GroupUser() done!");

        }

        public static void GroupPolicy() // This is useless, I guess.
        {
            Console.WriteLine("Executing GroupPolicy()...");
            XDocument doc = new XDocument();
            GPDomain domain = new GPDomain();
            XElement xmlDomain = new XElement("domain");

            int count = 0;

            GpoCollection gpos = domain.GetAllGpos();
            doc.Add(xmlDomain);
            foreach (Gpo currentGpo in gpos)
            {
                xmlDomain.Add(new XElement("GPO",
                            new XElement("Computer", currentGpo.Computer),
                            new XElement("Description", currentGpo.Description),
                            new XElement("DisplayName", currentGpo.DisplayName),
                            new XElement("DomainName", currentGpo.DomainName),
                            new XElement("GpoStatus", currentGpo.GpoStatus),
                            new XElement("Id", currentGpo.Id),
                            new XElement("ModificationTime", currentGpo.ModificationTime),
                            new XElement("Owner", currentGpo.Owner),
                            new XElement("Path", currentGpo.Path),
                            new XElement("User", currentGpo.User),
                            new XElement("WmiFilter", currentGpo.WmiFilter)
                            ));
                count++;
                Console.WriteLine(count);
                //if (count >= 20) break; //for testing purposes
            }
            doc.Save("D:\\GroupPolicy.xml");
            Console.WriteLine("GroupPolicy() done!");

        }

        public static void CreateDummy(string username, string password, string description) // for testing
        {
            DirectoryEntry AD = new DirectoryEntry("WinNT://" + Environment.MachineName + ",computer");
            DirectoryEntry NewUser = AD.Children.Add(username, "user");
            NewUser.Invoke("SetPassword", new object[] { password });
            NewUser.Invoke("Put", new object[] { "Description", description });
            NewUser.CommitChanges();
        }

        public static void CreateNewUseraccount(string folderPath)
        {
            XDocument doc = XDocument.Load(folderPath);
            //int count = 0;

            var item = from q in doc.Descendants("User")
                       select new
                       {
                           AccountType = q.Element("AccountType").Value,
                           Caption = q.Element("Caption").Value,
                           Description = q.Element("Description").Value,
                           Disabled = q.Element("Disabled").Value,
                           Domain = q.Element("Domain").Value,
                           FullName = q.Element("FullName").Value,
                           InstallDate = q.Element("InstallDate").Value,
                           LocalAccount = q.Element("LocalAccount").Value,
                           Lockout = q.Element("Lockout").Value,
                           Name = q.Element("Name").Value,
                           PasswordChangeable = q.Element("PasswordChangeable").Value,
                           PasswordExpires = q.Element("PasswordExpires").Value,
                           SID = q.Element("SID").Value,
                           SIDType = q.Element("SIDType").Value,
                           Status = q.Element("Status").Value
                       };

            foreach (var data in item)
            {
                MakeNewUser(
                    data.AccountType,
                    data.Caption,
                    data.Description,
                    data.Disabled,
                    data.Domain,
                    data.FullName,
                    data.InstallDate,
                    data.LocalAccount,
                    data.Lockout,
                    data.Name,
                    data.PasswordChangeable,
                    data.PasswordExpires,
                    data.SID,
                    data.SIDType,
                    data.Status
                    );
            }

        }

        public static void CreateNewGroup(string folderPath)
        {
            XDocument doc = XDocument.Load(folderPath);

            var item = from q in doc.Descendants("User")
                       select new
                       {
                           Caption = q.Element("Caption").Value,
                           Description = q.Element("Description").Value,
                           Domain = q.Element("Domain").Value,
                           InstallDate = q.Element("InstallDate").Value,
                           LocalAccount = q.Element("LocalAccount").Value,
                           Name = q.Element("Name").Value,
                           SID = q.Element("SID").Value,
                           SIDType = q.Element("SIDType").Value,
                           Status = q.Element("Status").Value
                       };


            int count = 0;

            foreach (var data in item)
            {
                MakeNewGroup(
                    data.Caption,
                    data.Description,
                    data.Domain,
                    data.InstallDate,
                    data.LocalAccount,
                    data.Name,
                    data.SID,
                    data.SIDType,
                    data.Status
                    );

                count++;
            }

        }


        public static void MakeNewUser(
            string AccountType,
            string Caption,
            string Description,
            string Disabled,
            string Domain,
            string FullName,
            string InstallDate,
            string LocalAccount,
            string Lockout,
            string Name,
            string PasswordChangeable,
            string PasswordExpires,
            string SID,
            string SIDType,
            string Status)
        {
            //if (  )

            DirectoryEntry activeDirectory = new DirectoryEntry("WinNT://" + Environment.MachineName + ",computer");
            DirectoryEntry NewUser = activeDirectory.Children.Add(Name, "user");
            NewUser.Invoke("Put", new object[] { "AccountType", AccountType });
            NewUser.Invoke("Put", new object[] { "Caption", Caption });
            NewUser.Invoke("Put", new object[] { "Description", Description });
            NewUser.Invoke("Put", new object[] { "Disabled", Disabled });
            NewUser.Invoke("Put", new object[] { "Domain", Domain });
            NewUser.Invoke("Put", new object[] { "FullName", FullName });
            NewUser.Invoke("Put", new object[] { "InstallDate", InstallDate });
            NewUser.Invoke("Put", new object[] { "LocalAccount", LocalAccount });
            NewUser.Invoke("Put", new object[] { "Lockout", Lockout });
            NewUser.Invoke("Put", new object[] { "PasswordChangeable", PasswordChangeable });
            NewUser.Invoke("Put", new object[] { "PasswordExpires", PasswordExpires });
            NewUser.Invoke("Put", new object[] { "SID", SID });
            NewUser.Invoke("Put", new object[] { "SIDType", SIDType });
            NewUser.Invoke("Put", new object[] { "Status", Status });

            NewUser.CommitChanges();

        }

        public static void MakeNewGroup(
            string Caption,
            string Description,
            string Domain,
            string InstallDate,
            string LocalAccount,
            string Name,
            string SID,
            string SIDType,
            string Status)
        {
            //if (  )

            DirectoryEntry activeDirectory = new DirectoryEntry("WinNT://" + Environment.MachineName + ",computer");
            DirectoryEntry NewUser = activeDirectory.Children.Add(Name, "user");
            NewUser.Invoke("Put", new object[] { "Caption", Caption });
            NewUser.Invoke("Put", new object[] { "Description", Description });
            NewUser.Invoke("Put", new object[] { "Domain", Domain });
            NewUser.Invoke("Put", new object[] { "InstallDate", InstallDate });
            NewUser.Invoke("Put", new object[] { "LocalAccount", LocalAccount });
            NewUser.Invoke("Put", new object[] { "SID", SID });
            NewUser.Invoke("Put", new object[] { "SIDType", SIDType });
            NewUser.Invoke("Put", new object[] { "Status", Status });

            NewUser.CommitChanges();

        }



        public static void ReadGroups(string folderPath)
        {
            XDocument doc = XDocument.Load(folderPath);
            int count = 0;

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

            foreach (var x in item)
            {
                MakePrincipalGroup(x.Description, x.DisplayName, x.DistinguishedName, x.GroupScope, x.IsSecurityGroup, x.Name, x.SamAccountName, x.UserPrincipalName);
                count++;
                if (count >= 100) break;
            }

        }

        public static void ReadUsers(string folderPath)
        {
            XDocument doc = XDocument.Load(folderPath);
            int count = 0;

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

            foreach (var x in item)
            {
                MakePrincipalUser(x.AllowReversiblePasswordEncryption, x.DelegationPermitted, x.Description, x.DisplayName, x.EmailAddress, x.EmployeeId, x.Enabled, x.GivenName, x.HomeDirectory, x.HomeDrive, x.MiddleName, x.Name, x.PasswordNeverExpires, x.PasswordNotRequired, x.PermittedWorkstations, x.SamAccountName, x.ScriptPath, x.SmartcardLogonRequired, x.Surname, x.UserCannotChangePassword, x.UserPrincipalName, x.VoiceTelephoneNumber);
                count++;
                if (count >= 100) break;
            }


        }
        public static void RRRRRRRRRRRReadUsers(string folderPath)
        {
            XDocument doc = XDocument.Load(folderPath);
            int count = 0;

            var item = from q in doc.Descendants("User")
                       select new
                       {
                           AccountType = q.Element("AccountType").Value,
                           Caption = q.Element("Caption").Value,
                           Description = q.Element("Description").Value,
                           Disabled = q.Element("Disabled").Value,
                           Domain = q.Element("Domain").Value,
                           FullName = q.Element("FullName").Value,
                           InstallDate = q.Element("InstallDate").Value,
                           LocalAccount = q.Element("LocalAccount").Value,
                           Lockout = q.Element("Lockout").Value,
                           Name = q.Element("Name").Value,
                           PasswordChangeable = q.Element("PasswordChangeable").Value,
                           PasswordExpires = q.Element("PasswordExpires").Value,
                           SID = q.Element("SID").Value,
                           SIDType = q.Element("SIDType").Value,
                           Status = q.Element("Status").Value
                       };

            foreach (var x in item)
            {
                Console.WriteLine(x.AccountType);
                Console.WriteLine(x.Caption);
                Console.WriteLine(x.Description);
                Console.WriteLine(x.Disabled);
                Console.WriteLine(x.Domain);
                Console.WriteLine(x.FullName);
                Console.WriteLine(x.InstallDate);
                Console.WriteLine(x.LocalAccount);
                Console.WriteLine(x.Lockout);
                Console.WriteLine(x.Name);
                Console.WriteLine(x.PasswordChangeable);
                Console.WriteLine(x.PasswordExpires);
                Console.WriteLine(x.SID);
                Console.WriteLine(x.SIDType);
                Console.WriteLine(x.Status);
                count++;
                if (count >= 1) break;
            }

        }

        public static void ReadFileOld(string folderPath)
        {
            XDocument doc = XDocument.Load(folderPath);
            var group = doc.Descendants("Group");
            int count = 0;

            var item = group.Descendants("Name");

            foreach (var element in item)
            {
                Console.WriteLine(element);
                count++;
                if (count >= 10) break;
            }
        }

        public static bool CreateLocalWindowsAccount(string username)
        {
            try
            {
                PrincipalContext context = new PrincipalContext(ContextType.Machine);
                UserPrincipal user = new UserPrincipal(context);
                user.SetPassword("ala");
                user.DisplayName = username;
                user.Name = username;
                user.Save();
                //now add user to "Users" group so it displays in Control Panel
                GroupPrincipal group = GroupPrincipal.FindByIdentity(context, "Users");
                group.Members.Add(user);
                group.Save();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error creating account: {0}", ex.Message);
                return false;
            }

        }

        public static void QueryPrincipalUsers()
        {
            Console.WriteLine("Making QueryPrincipalUsers constructors...");

            PrincipalContext AD = new PrincipalContext(ContextType.Domain);
            UserPrincipal user = new UserPrincipal(AD);
            PrincipalSearcher search = new PrincipalSearcher(user);

            Console.WriteLine("Making new document...");

            XDocument doc = new XDocument();
            XElement accountList = new XElement("account_list");
            XElement xuser = new XElement("User");
            doc.Add(accountList);


            int count = 0;


            Console.WriteLine("User count: " + search.FindAll().Count().ToString());
            Console.WriteLine("Querying users");
            foreach (UserPrincipal result in search.FindAll())
            {
                if (result != null && result.DisplayName != null)
                {                  
                    accountList.Add(new XElement("User",
                                    new XElement("AccountExpirationDate", result.AccountExpirationDate),
                                    new XElement("AccountLockoutTime", result.AccountLockoutTime),
                                    new XElement("AdvancedSearchFilter", result.AdvancedSearchFilter),
                                    new XElement("AllowReversiblePasswordEncryption", result.AllowReversiblePasswordEncryption),
                                    new XElement("BadLogonCount", result.BadLogonCount),
                                    new XElement("Certificates", result.Certificates),
                                    new XElement("Context", result.Context),
                                    //new XElement("ContextRaw", result.ContextRaw),
                                    new XElement("ContextType", result.ContextType),
                                    //new XElement("Current", result.Current),
                                    new XElement("DelegationPermitted", result.DelegationPermitted),
                                    new XElement("Description", result.Description),
                                    new XElement("DisplayName", result.DisplayName),
                                    new XElement("DistinguishedName", result.DistinguishedName),
                                    new XElement("EmailAddress", result.EmailAddress),
                                    new XElement("EmployeeId", result.EmployeeId),
                                    new XElement("Enabled", result.Enabled),
                                    new XElement("GivenName", result.GivenName),
                                    new XElement("Guid", result.Guid),
                                    new XElement("HomeDirectory", result.HomeDirectory),
                                    new XElement("HomeDrive", result.HomeDrive),
                                    new XElement("LastBadPasswordAttempt", result.LastBadPasswordAttempt),
                                    new XElement("LastLogon", result.LastLogon),
                                    new XElement("LastPasswordSet", result.LastPasswordSet),
                                    new XElement("MiddleName", result.MiddleName),
                                    new XElement("Name", result.Name),
                                    new XElement("PasswordNeverExpires", result.PasswordNeverExpires),
                                    new XElement("PasswordNotRequired", result.PasswordNotRequired),
                                    new XElement("PermittedLogonTimes", result.PermittedLogonTimes),
                                    new XElement("PermittedWorkstations", result.PermittedWorkstations),
                                    new XElement("SamAccountName", result.SamAccountName),
                                    new XElement("ScriptPath", result.ScriptPath),
                                    new XElement("Sid", result.Sid),
                                    new XElement("SmartcardLogonRequired", result.SmartcardLogonRequired),
                                    new XElement("StructuralObjectClass", result.StructuralObjectClass),
                                    new XElement("Surname", result.Surname),
                                    new XElement("UserCannotChangePassword", result.UserCannotChangePassword),
                                    new XElement("UserPrincipalName", result.UserPrincipalName),
                                    new XElement("VoiceTelephoneNumber", result.VoiceTelephoneNumber)
                                    ));

                    count++;
                    //if (count >= 420) break;
                }
            }
            doc.Save("D:\\useraccounts.xml");
            Console.WriteLine("QueryPrincipalUsers done!");
            //Console.WriteLine(count);
        }

        public static void QueryPrincipalGroups()
        {
            PrincipalContext AD = new PrincipalContext(ContextType.Domain);
            GroupPrincipal group = new GroupPrincipal(AD);
            PrincipalSearcher search = new PrincipalSearcher(group);

            XDocument doc = new XDocument();
            XElement groupList = new XElement("group_list");
            doc.Add(groupList);


            int count = 0;
            string domain = null;

            foreach (GroupPrincipal result in search.FindAll())
            {
                if (result != null && result.DisplayName != null)
                {

                    /**
                    Console.WriteLine(result.Context);
                    Console.WriteLine(result.ContextType);
                    Console.WriteLine(result.Description);
                    Console.WriteLine(result.DisplayName);
                    Console.WriteLine(result.DistinguishedName);
                    Console.WriteLine(result.GroupScope);
                    Console.WriteLine(result.Guid);
                    Console.WriteLine(result.IsSecurityGroup);
                    Console.WriteLine(result.Members);
                    Console.WriteLine(result.Name);
                    Console.WriteLine(result.SamAccountName);
                    Console.WriteLine(result.Sid);
                    Console.WriteLine(result.StructuralObjectClass);
                    Console.WriteLine(result.UserPrincipalName);
                    **/
                    domain = result.DistinguishedName.Substring(result.DistinguishedName.LastIndexOf("OU=") + 3);
                    domain = domain.Substring(0, domain.IndexOf(","));

                    groupList.Add(new XElement("Group",
                                    new XElement("Context", result.Context),
                                    new XElement("ContextType", result.ContextType),
                                    new XElement("Description", result.Description),
                                    new XElement("DisplayName", result.DisplayName),
                                    new XElement("DistinguishedName", result.DistinguishedName),
                                    new XElement("Domain", domain),
                                    new XElement("GroupScope", result.GroupScope),
                                    new XElement("Guid", result.Guid),
                                    new XElement("IsSecurityGroup", result.IsSecurityGroup),
                                    //new XElement("Members", result.Members),
                                    new XElement("Name", result.Name),
                                    new XElement("SamAccountName", result.SamAccountName),
                                    new XElement("Sid", result.Sid),
                                    new XElement("StructuralObjectClass", result.StructuralObjectClass),
                                    new XElement("UserPrincipalName", result.UserPrincipalName)
                                    ));
                    

                    count++;
                    //if (count >= 420) break;
                }
            }
            doc.Save("D:\\groups.xml");
            Console.WriteLine(count);

        }

        public static void MakePrincipalUser(
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
                PrincipalContext context = new PrincipalContext(ContextType.Machine);
                UserPrincipal user = new UserPrincipal(context);
                user.Name = Name;
                user.SetPassword("ala");
                Console.WriteLine("Password and set");
                //now add user to "Users" group so it displays in Control Panel


                Console.WriteLine("Initial account saved");


                //user.AccountExpirationDate = Convert.ToDateTime(String.Empty);
                //user.AccountLockoutTime = AccountLockoutTime; // read only
                //user.AdvancedSearchFilter = AdvancedSearchFilter; // read only
                user.AllowReversiblePasswordEncryption = Convert.ToBoolean(AllowReversiblePasswordEncryption);
                Console.WriteLine("AllowReversiblePasswordEncryption set");

                //user.BadLogonCount = BadLogonCount; // read only
                //user.Certificates = Certificates; // read only
                //user.Context = Context; // read only
                //user.ContextType = ContextType; // ContextType is Domain
                user.DelegationPermitted = Convert.ToBoolean(DelegationPermitted);
                Console.WriteLine("DelegationPermitted set");

                user.Description = Description;
                Console.WriteLine("Description set");

                user.DisplayName = DisplayName;
                Console.WriteLine("DisplayName set");

                //user.DistinguishedName = DistinguishedName; // read only
                user.EmailAddress = EmailAddress.ToString();
                Console.WriteLine("EmailAddress set");

                //user.EmployeeId = EmployeeId.ToString();
                //Console.WriteLine("EmployeeId set");

                user.Enabled = Convert.ToBoolean(Enabled);
                Console.WriteLine("Enabled set");

                //user.GivenName = GivenName;
                //Console.WriteLine("GivenName set");

                //user.Guid = Guid; // read only
                user.HomeDirectory = HomeDirectory;
                Console.WriteLine("HomeDirectory set");

                user.HomeDrive = HomeDrive;
                Console.WriteLine("HomeDrive set");

                //user.LastBadPasswordAttempt = LastBadPasswordAttempt; // read only
                //user.LastLogon = LastLogon; // read only
                //user.LastPasswordSet = LastPasswordSet; // read only
                //user.MiddleName = MiddleName;
                //Console.WriteLine("MiddleName set");

                user.PasswordNeverExpires = Convert.ToBoolean(PasswordNeverExpires);
                Console.WriteLine("PasswordNeverExpires set");

                user.PasswordNotRequired = Convert.ToBoolean(PasswordNotRequired);
                Console.WriteLine("PasswordNotRequired set");

                //user.PermittedLogonTimes = new byte[Convert.ToByte(PermittedLogonTimes)];
                //Console.WriteLine("PermittedLogonTimes set");

                //user.PermittedWorkstations = PermittedWorkstations; // read only
                user.SamAccountName = SamAccountName; // read only
                user.ScriptPath = ScriptPath;
                Console.WriteLine("ScriptPath set");

                //user.Sid = Sid; // read only
                user.SmartcardLogonRequired = Convert.ToBoolean(SmartcardLogonRequired);
                Console.WriteLine("SmartcardLogonRequired set");

                //user.StructuralObjectClass = StructuralObjectClass; // read only
                //user.Surname = Surname;
                //Console.WriteLine("Surname set");

                user.UserCannotChangePassword = Convert.ToBoolean(UserCannotChangePassword);
                Console.WriteLine("UserCannotChangePassword set");

                //user.UserPrincipalName = UserPrincipalName;
                //Console.WriteLine("UserPrincipalName set");

                //user.VoiceTelephoneNumber = VoiceTelephoneNumber;
                //Console.WriteLine("VoiceTelephoneNumber set");


                user.Save();
                GroupPrincipal groupPrinc = GroupPrincipal.FindByIdentity(context, "Users");
                groupPrinc.Members.Add(user);
                groupPrinc.Save();
                Console.WriteLine("User saved");
                return;



            }
            catch (Exception ex)
            {
                Console.WriteLine("Error creating account: {0}", ex.Message);

            }

        }

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
                PrincipalContext context = new PrincipalContext(ContextType.Domain); // Add Domain and DistinguishedName
                GroupPrincipal group = new GroupPrincipal(context, SamAccountName);


                //PrincipalContext context = new PrincipalContext(ContextType.Domain);
                //GroupPrincipal group = new GroupPrincipal(context);

                if(Description != string.Empty)
                {
                    group.Description = Description;
                    Console.WriteLine("Description set!");
                }

                group.DisplayName = DisplayName;
                Console.WriteLine("DisplayName set!");

                switch (varGroupScope)
                {
                    case "Local": Console.WriteLine("Local scope"); group.GroupScope = GroupScope.Local; break;
                    case "Global": Console.WriteLine("Global scope"); group.GroupScope = GroupScope.Global; break;
                    case "Universal": Console.WriteLine("Universal scope"); group.GroupScope = GroupScope.Universal; break;
                }
                Console.WriteLine("GroupScope set!");

                group.IsSecurityGroup = Convert.ToBoolean(IsSecurityGroup);
                Console.WriteLine("IsSecurityGroup set!");

                group.Name = Name;
                Console.WriteLine("Name set!");

                group.SamAccountName = SamAccountName;
                Console.WriteLine("SamAccountName set!");

                if (UserPrincipalName != string.Empty)
                {
                    group.UserPrincipalName = UserPrincipalName;
                    Console.WriteLine("UserPrincipalName set!");
                }


                group.Save();
                Console.WriteLine("Group saved!");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error creating account: {0}", ex.Message);
            }

        }

        public static void QueryGroupsMembers()
        {
            PrincipalContext AD = new PrincipalContext(ContextType.Domain);
            UserPrincipal group = new UserPrincipal(AD);
            PrincipalSearcher search = new PrincipalSearcher(group);

            XDocument doc = new XDocument();
            XElement groupList = new XElement("groupsusers");
            doc.Add(groupList);


            int count = 0;
            PrincipalSearchResult<Principal> groupMembers;

            foreach (UserPrincipal result in search.FindAll())
            {
                if (result != null && result.DisplayName != null)
                {
                    groupMembers = result.GetGroups();
                    //Console.WriteLine(groupMembers.ToString());

                    foreach (Principal principal in result.GetGroups())
                    {
                        groupList.Add(new XElement("User",
                                        new XElement("Username", result.SamAccountName),
                                        new XElement("GroupName", principal.SamAccountName)
                                        ));
                    }
                }
                count++;
                if (count >= 100) break;
            }
            doc.Save("D:\\groupsusers.xml");
            Console.WriteLine(count);
        }


        public static void UsersToGroups(string folderPath)
        {
            XDocument doc = XDocument.Load(folderPath);
            int count = 0;
            Console.WriteLine("File loaded");

            var item = from q in doc.Descendants("User")
                       select new
                       {
                           Username = q.Element("Username").Value,
                           GroupName = q.Element("GroupName").Value
                       };
            Console.WriteLine("XML read");

            foreach (var x in item)
            {
                Console.WriteLine("Adding user");
                AddMemberToGroup(x.Username, x.GroupName);
                count++;
                if (count >= 200) break;
            }

        }

        public static void AddMemberToGroup(string userName, string groupName )
        {
            try
            {
                PrincipalContext AD = new PrincipalContext(ContextType.Domain);
                GroupPrincipal group = GroupPrincipal.FindByIdentity(AD, IdentityType.SamAccountName, groupName);
                Console.WriteLine("Group: " + group.ToString());
                group.Members.Add(AD, IdentityType.SamAccountName, userName);
                group.Save();
                Console.WriteLine("User \"" + userName + "\" added to group \"" + groupName);
            }

            catch (Exception e)
            {
                Console.WriteLine("An error occurred. {0}", e.Message);
            }
        }
    }
}
