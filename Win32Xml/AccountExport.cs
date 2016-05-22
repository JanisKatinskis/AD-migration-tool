using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using System.Xml;
using System.Xml.Linq;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Windows.Forms;
using System.IO;


namespace Win32Xml
{

    /// <summary>
    /// This class contains all the functions that are responsible 
    /// for reading user and group info and exporting it to XML.
    /// </summary>
    class AccountExport
    {

        /// <summary>
        /// Function that queries all users in Active Directory and saves their info to an XML file.
        /// </summary>
        /// <param name="QueryPrincipalUsers"></param>
        public static void QueryPrincipalUsers(string folderPath, string fileName)
        {
            
            try
            {
                // PrincipalContext constructor
                PrincipalContext AD = new PrincipalContext(ContextType.Domain);

                // UserPrincipal constructor
                UserPrincipal user = new UserPrincipal(AD);

                // Searcher variable that will be used for querying Active Directory.
                PrincipalSearcher search = new PrincipalSearcher(user);



                // XML document constructor
                XDocument doc = new XDocument();

                // Creates groupList element that will serve as a container for all of the content.
                XElement accountList = new XElement("account_list");

                // Adds account_list tag to the document.
                doc.Add(accountList);



                // Searches the Active Directory and gets info from every user.
                foreach (UserPrincipal result in search.FindAll())
                {
                    // calls the function to 
                    WriteToUserExportFile(result, accountList);
                }

                // Saves the document to defined folderpath
                doc.Save(folderPath + fileName + ".xml");

            }

            // Error handler
            catch ( Exception e )
            {
                MessageBox.Show(e.Message, "An error occurred",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


        /// <summary>
        /// Reads user account info from the Active Directory and writes it to XML file
        /// </summary>
        /// <param name="result">Instance of the current UserPrincipal</param>
        /// <param name="accountList">The main XML element</param>
        public static void WriteToUserExportFile(UserPrincipal result, XElement accountList)
        {
            try
            {
                // Writes all the info about the user to XML.
                accountList.Add(new XElement("User",
                                new XElement("AccountExpirationDate", result.AccountExpirationDate),
                                new XElement("AccountLockoutTime", result.AccountLockoutTime),
                                new XElement("AdvancedSearchFilter", result.AdvancedSearchFilter),
                                new XElement("AllowReversiblePasswordEncryption", result.AllowReversiblePasswordEncryption),
                                new XElement("BadLogonCount", result.BadLogonCount),
                                new XElement("Certificates", result.Certificates),
                                new XElement("Context", result.Context),
                                new XElement("ContextType", result.ContextType),
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
                                new XElement("VoiceTelephoneNumber", result.VoiceTelephoneNumber))
                                );

                // Checks if the "Generate Report" checkbox is ticked
                if (Global.generateReport == true)
                {
                    // Adds report entry about the current user
                    Utility.addToReportFile("User account \"" + result.SamAccountName + "\" info exported successfully");
                }
            }
            catch ( Exception e )
            {
                // Checks if the "Generate Report" checkbox is ticked
                if (Global.generateReport == true)
                {
                    // Adds report entry if there is an error exporting information
                    Utility.addToReportFile("Error exporting account \"" + result.SamAccountName + "\": " + e.Message);
                }
            }
        }

        /// <summary>
        /// This function queries all groups in Active Directory and saves their info to an XML file.
        /// </summary>
        /// <param name="QueryPrincipalGroups"></param>
        public static void QueryPrincipalGroups(string folderPath, string fileName)
        {

            try
            {
                // PrincipalContext constructor
                PrincipalContext AD = new PrincipalContext(ContextType.Domain);

                // GroupPrincipal constructor
                GroupPrincipal group = new GroupPrincipal(AD);

                // Searcher variable that will be used for querying Active Directory.
                PrincipalSearcher search = new PrincipalSearcher(group);



                // XML document constructor
                XDocument doc = new XDocument();

                // Creates groupList element that will serve as a container for all of the content.
                XElement groupList = new XElement("group_list");

                // Adds groupList tag to the document.
                doc.Add(groupList);



                // Searches the Active Directory and gets info from every group.
                foreach (GroupPrincipal result in search.FindAll())
                {



                }

                // Saves the document to defined folderpath
                doc.Save(folderPath + fileName + ".xml");

            }

            // Error handler
            catch (Exception e)
            {
                MessageBox.Show("An error occurred. {0}", e.Message);
            }

        }

        /// <summary>
        /// Reads group info from the Active Directory and writes it to XML file
        /// </summary>
        /// <param name="result">Instance of the current UserPrincipal</param>
        /// <param name="accountList">The main XML element</param>
        public static void WriteToGroupExportFile(GroupPrincipal result, XElement groupList)
        {
            try
            {
                // Writes all the info about the group to XML.
                groupList.Add(new XElement("Group",
                                new XElement("Context", result.Context),
                                new XElement("ContextType", result.ContextType),
                                new XElement("Description", result.Description),
                                new XElement("DisplayName", result.DisplayName),
                                new XElement("DistinguishedName", result.DistinguishedName),
                                new XElement("GroupScope", result.GroupScope),
                                new XElement("Guid", result.Guid),
                                new XElement("IsSecurityGroup", result.IsSecurityGroup),
                                new XElement("Name", result.Name),
                                new XElement("SamAccountName", result.SamAccountName),
                                new XElement("Sid", result.Sid),
                                new XElement("StructuralObjectClass", result.StructuralObjectClass),
                                new XElement("UserPrincipalName", result.UserPrincipalName)
                                ));

                // Checks if the "Generate Report" checkbox is ticked
                if (Global.generateReport == true)
                {
                    // Adds report entry about the current user
                    Utility.addToReportFile("Group \"" + result.SamAccountName + "\" info exported successfully");
                }

            }

            catch (Exception e)
            {
                // Checks if the "Generate Report" checkbox is ticked
                if (Global.generateReport == true)
                {
                    // Adds report entry if there is an error exporting information
                    Utility.addToReportFile("Error exporting group \"" + result.SamAccountName + "\": " + e.Message);
                }
            }

        }

        /// <summary>
        /// This function reads Active Directory's user-group relationship (what users are members of what groups)
        /// and exports it to an XML file.
        /// The info in XML file is stored like an SQL relation table.
        /// </summary>
        /// <param name="QueryGroupsMembers"></param>
        public static void QueryGroupsMembers(string folderPath, string fileName)
        {

            try
            {
                // PrincipalContext constructor
                PrincipalContext AD = new PrincipalContext(ContextType.Domain);

                // UserPrincipal constructor
                UserPrincipal group = new UserPrincipal(AD);

                // Searcher variable that will be used for querying Active Directory.
                PrincipalSearcher search = new PrincipalSearcher(group);

                // XML Document constructor
                XDocument doc = new XDocument();

                // Creates groupsusers element that will serve as a container for all of the content.
                XElement groupList = new XElement("groupsusers");

                // Adds groupsusers tag to the document.
                doc.Add(groupList);

                // Searches the Active Directory and returns list of all users
                foreach (UserPrincipal result in search.FindAll())
                {

                    // Gets each user and creates an XML entry for it containing user SamAccountName and group SamAccountName.
                    foreach (Principal principal in result.GetGroups())
                    {
                    }
                }

                // Saves the file to the given folder path.
                doc.Save(folderPath + fileName + ".xml");

            }

            // Error handler
            catch (Exception e)
            {
                MessageBox.Show("An error occurred. {0}", e.Message);
            }

        }

        public static void WriteToGroupMemberExportFile(UserPrincipal result, Principal principal, XElement groupList)
        {
            try
            {
                groupList.Add(new XElement("User",
                    new XElement("Username", result.SamAccountName),
                    new XElement("GroupName", principal.SamAccountName)
                    ));
            }

            catch (Exception e)
            {
                // Checks if the "Generate Report" checkbox is ticked
                if (Global.generateReport == true)
                {
                    // Adds report entry if there is an error exporting information
                    Utility.addToReportFile("Error exporting group \"" + principal.SamAccountName + "\" + user \"" + result.SamAccountName + "\": " + e.Message);
                }
            }

        }


        /// <summary>
        /// This function generetes log file that will contain report of exported users, groups, and members of groups.
        /// The report file is named after the date of export.
        /// </summary>
        /// <param name="filePath">Path where the file will be saved</param>
        /// <param name="fileName">Name of the file</param>
        public static void generateExportReportFile(string filePath)
        {
            // Sets the path to the report file
            Global.reportFullPath = filePath + "ExportReport_" + DateTime.Today.Date.ToString("dd.MM.yyyy") + ".txt";
            
            // Creates new report file containing the current date.
            StreamWriter file = new StreamWriter(Global.reportFullPath);

            // Writes the heading of the file in the first line
            file.WriteLine("ACTIVE DIRECTORY EXPORT REPORT " + DateTime.Today.Date.ToString("dd.MM.yyyy"));
            file.WriteLine(String.Empty);

            // Closes the text file
            file.Close();
        }

    }

}