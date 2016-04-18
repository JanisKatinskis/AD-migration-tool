using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Xml;
using System.Xml.Linq;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Windows.Forms;


namespace Win32Xml
{
    class AccountImport
    {

        public static void ReadGroups(string folderPath)
        {
            XDocument doc = XDocument.Load(folderPath);
            int count = 0;

            var item = from q in doc.Descendants("Group")
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

            foreach (var x in item)
            {
                count++;
                if (count >= 2) break;
            }

        }

        public static void ReadUsers(string folderPath)
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

                count++;
                if (count >= 1) break;
            }

        }




        public static bool CreateAccount(
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
            string Status )
        {
            try
            {
                PrincipalContext context = new PrincipalContext(ContextType.Machine);
                UserPrincipal user = new UserPrincipal(context);
                //user.SetPassword(password);
                user.AccountType = AccountType;
                user.Name = Name;
                user.Description = Description;
                user.UserCannotChangePassword = PasswordChangeable;
                user.PasswordNeverExpires = PasswordExpires;
                user.Save();
                //now add user to "Users" group so it displays in Control Panel
                GroupPrincipal group = GroupPrincipal.FindByIdentity(context, "Users");
                group.Members.Add(user);
                group.Save();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating account: {0}", ex.Message);
                return false;
            }

        }

        public static void CreateDummy(string username, string password, string description) // for testing
        {
            DirectoryEntry AD = new DirectoryEntry("WinNT://" + Environment.MachineName + ",computer");
            DirectoryEntry NewUser = AD.Children.Add(username, "user");
            NewUser.Invoke("SetPassword", new object[] { password });
            NewUser.Invoke("Put", new object[] { "Description", description });
            NewUser.CommitChanges();
        }

    }


}
