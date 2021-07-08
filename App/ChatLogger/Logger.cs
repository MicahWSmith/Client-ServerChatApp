using System;
using BusinessClass;
using System.IO;
using System.Diagnostics;

namespace ChatLogger
{
    /// <summary>
    /// Methods for creating and writing log files
    /// </summary>
    public class Logger : ILoggingService
    {
        // Filename placeholder
        String fName;
        /// <summary>
        /// Create new log file named after time stamp string
        /// </summary>
        public void NewLog()
        {
            // build filename string out of timestamp and create file
            fName = DateTime.Now.ToString("MM_dd_yyyy_HH_mm");
            File.Create(fName+".log");
        }
        /// <summary>
        /// Write message to log file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void LogMessage(object sender, MessageArgs e)
        {
            Log(e.Message);
        }

        public void Log(String message)
        {
            using (StreamWriter sw = File.AppendText(fName + ".log"))
            {
                // build log string out of message and formatted date
                String logString = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss zz") + " - " + message;
                sw.WriteLine(logString);
            }
        }
    }
}
