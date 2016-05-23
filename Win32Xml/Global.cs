using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win32Xml
{

    /// <summary>
    /// Class containing global variables
    /// </summary>
    class Global
    {
        // Initial password for user accounts
        private static string _password = "";

        // Contains path to report file folder
        private static string _reportPath = "";

        // Wheter report will be generated
        private static bool _generateReport = true;

        // Contains path to report file folder
        private static string _reportFullPath = "";

        // Contains path to exported user info file
        private static string _exportUserPath = "";

        // Contains path to exported group info file
        private static string _exportGroupPath = "";

        // Contains path to exported group members' info file
        private static string _exportGroupUserPath = "";

        // Contains path to imported user info file
        private static string _importUserPath = "";

        // Contains path to imported group info file
        private static string _importGroupPath = "";

        // Contains path to imported group members' info file
        private static string _importGroupUserPath = "";


        // Function to get or set the report file folder path
        public static string password
        {
            get { return _password; }
            set { _password = value; }
        }

        // Function to get or set the report file folder path
        public static string reportPath
        {
            get { return _reportPath; }
            set { _reportPath = value; }
        }

        // Function to get or set the full report file path
        public static string reportFullPath
        {
            get { return _reportFullPath; }
            set { _reportFullPath = value; }
        }

        // Function to get or set the boolean for report generation
        public static bool generateReport
        {
            get { return _generateReport; }
            set { _generateReport = value; }
        }

        // Function to get or set the user export path
        public static string exportUserPath
        {
            get { return _exportUserPath; }
            set { _exportUserPath = value; }
        }

        // Function to get or set the group export path
        public static string exportGroupPath
        {
            get { return _exportGroupPath; }
            set { _exportGroupPath = value; }
        }

        // Function to get or set the group members export path
        public static string exportGroupUserPath
        {
            get { return _exportGroupUserPath; }
            set { _exportGroupUserPath = value; }
        }

        // Function to get or set the user import path
        public static string importUserPath
        {
            get { return _importUserPath; }
            set { _importUserPath = value; }
        }

        // Function to get or set the user import path
        public static string importGroupPath
        {
            get { return _importGroupPath; }
            set { _importGroupPath = value; }
        }

        // Function to get or set the group member import path
        public static string importGroupUserPath
        {
            get { return _importGroupUserPath; }
            set { _importGroupUserPath = value; }
        }

    }
}
