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
        // Contains path to report file folder
        private static string _reportPath = "";

        // Contains path to report file folder
        private static string _reportFullPath = "";

        // Wheter report will be generated
        private static bool _generateReport = true;

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
    }
}
