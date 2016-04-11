using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using System.Xml;
using System.Xml.Linq;

namespace Win32Xml
{
    class AccountExport
    {

        public static void QueryGroups(string writePath) // Queries Win32_Group and exports to XML
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

            doc.Save(writePath + "\\" + "groups.xml");
            Console.WriteLine("QueryGroups() done!");

        }

        public static void QueryUsers(string writePath) // Queries Win32_UserAccount and exports to XML
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
                if (count >= 20) break; // For testing purposes
            }

            doc.Save(writePath + "\\" + "users.xml");
            Console.WriteLine("QueryUsers() done!");

        }

        public static void GroupUser(string writePath) // Queries Win32_GroupUser for group-user relation.
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

            doc.Save(writePath + "\\" + "groupuser.xml");
            Console.WriteLine("GroupUser() done!");

        }

    }

}