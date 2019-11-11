using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MT_Forms.Core
{
    internal class Logger
    {
        private static List<string> logList = new List<string>();
        private static readonly string LogFilePath = $"{Environment.CurrentDirectory}\\logs\\{DateTime.Now.ToShortDateString()}.txt";

        internal static void WriteAllLogInLogBox()
        {
            FormsInitialization.loginForm.LogBox.Items.Clear();
            foreach (var logMessage in logList)
            {
                FormsInitialization.loginForm.LogBox.Items.Add(logMessage);
            }
        }

        internal static void WriteInfoLogInLogBox()
        {
            FormsInitialization.loginForm.LogBox.Items.Clear();
            var infoLogList = logList.Where(item => item.Contains("INFO"));
            foreach (var logMessage in infoLogList)
            {
                FormsInitialization.loginForm.LogBox.Items.Add(logMessage);
            }
        }

        internal static void WriteErrorLogInLogBox()
        {
            FormsInitialization.loginForm.LogBox.Items.Clear();
            var infoLogList = logList.Where(item => item.Contains("ERROR"));
            foreach (var logMessage in infoLogList)
            {
                FormsInitialization.loginForm.LogBox.Items.Add(logMessage);
            }
        }

        internal static void WriteFatalLogInLogBox()
        {
            FormsInitialization.loginForm.LogBox.Items.Clear();
            var infoLogList = logList.Where(item => item.Contains("FATAL"));
            foreach (var logMessage in infoLogList)
            {
                FormsInitialization.loginForm.LogBox.Items.Add(logMessage);
            }
        }

        internal void Info(string logString)
        {
            var infoLogString = logString.Contains("Application started") ? $"\n\n{DateTime.Now} | INFO  | {logString}" : $"{DateTime.Now} | INFO  | {logString}";
            logList.Add(infoLogString);
            using (var logFile = new StreamWriter(LogFilePath, true))
            {
                //openFile
                logFile.WriteLine(infoLogString);
                if(logString.Contains("Application finished"))
                    logFile.Close();
            }
        }

        internal void Error(string logString)
        {
            var errorLogString = $"{DateTime.Now} | ERROR | {logString}";
            logList.Add(errorLogString);
            using (var logFile = new StreamWriter(LogFilePath, true))
            {
                logFile.WriteLine(errorLogString);
                if (logString.Contains("Application finished"))
                    logFile.Close();
            }
        }

        internal void Fatal(string logString)
        {
            var fatalLogString = $"{DateTime.Now} | FATAL | {logString}";
            logList.Add(fatalLogString);
            using (var logFile = new StreamWriter(LogFilePath, true))
            {
                logFile.WriteLine(fatalLogString);
                if (logString.Contains("Application finished"))
                    logFile.Close();
            }
        }
    }
}
