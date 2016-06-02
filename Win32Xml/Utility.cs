using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Win32Xml
{
    class Utility
    {
        /// <summary>
        /// Utility function to add content to the report file.
        /// Simple enough to be called on its own but kept as seperate function for the sake of ease of modification.
        /// </summary>
        /// <param name="filePath">Report file path</param>
        /// <param name="reportMessage">Message to be written in the file</param>
        public static void addToReportFile(string reportMessage)
        {

            // adds new line to the file containing report message.
            File.AppendAllText(Global.reportFullPath, reportMessage + Environment.NewLine);

        }

    }
}
