using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MT_Forms.Core.Logger
{
    internal class Logger
    {
        private static readonly List<string> LogList = new List<string>();
        private static readonly string LogDirectoryPath = $@"{Environment.CurrentDirectory}\logs";
        private static readonly string LogFilePath = $@"{Environment.CurrentDirectory}\logs\{DateTime.Now.ToShortDateString()}.txt";

        internal void CreateDirectoryForTextLog()
        {
            if (!Directory.Exists(LogDirectoryPath))
                Directory.CreateDirectory(LogDirectoryPath);
        }

        internal static void WriteAllLogInLogBox()
        {
            FormsStorage.mainProgramForm.LogBox.Items.Clear();
            foreach (var logMessage in LogList)
            {
                FormsStorage.mainProgramForm.LogBox.Items.Add(logMessage);
            }
        }

        internal static void WriteInfoLogInLogBox()
        {
            FormsStorage.mainProgramForm.LogBox.Items.Clear();
            var infoLogList = LogList.Where(item => item.Contains("INFO"));
            foreach (var logMessage in infoLogList)
            {
                FormsStorage.mainProgramForm.LogBox.Items.Add(logMessage);
            }
        }

        internal static void WriteErrorLogInLogBox()
        {
            FormsStorage.mainProgramForm.LogBox.Items.Clear();
            var infoLogList = LogList.Where(item => item.Contains("ERROR"));
            foreach (var logMessage in infoLogList)
            {
                FormsStorage.mainProgramForm.LogBox.Items.Add(logMessage);
            }
        }

        internal static void WriteFatalLogInLogBox()
        {
            FormsStorage.mainProgramForm.LogBox.Items.Clear();
            var infoLogList = LogList.Where(item => item.Contains("FATAL"));
            foreach (var logMessage in infoLogList)
            {
                FormsStorage.mainProgramForm.LogBox.Items.Add(logMessage);
            }
        }

        internal void Info(string logString)
        {
            var infoLogString = logString.Contains("Application started") ? $"\n\n{DateTime.Now} | INFO  | {logString}" : $"{DateTime.Now} | INFO  | {logString}";
            LogList.Add(infoLogString);
            CreateDirectoryForTextLog();
            using (var logFile = new StreamWriter(LogFilePath, true))
            {
                logFile.WriteLine(infoLogString);
                logFile.Close();
            }
        }

        internal void Error(string logString)
        {
            var errorLogString = $"{DateTime.Now} | ERROR | {logString}";
            LogList.Add(errorLogString);
            CreateDirectoryForTextLog();
            using (var logFile = new StreamWriter(LogFilePath, true))
            {
                logFile.WriteLine(errorLogString);
                logFile.Close();
            }
        }

        internal void Fatal(string logString)
        {
            var fatalLogString = $"{DateTime.Now} | FATAL | {logString}";
            LogList.Add(fatalLogString);
            CreateDirectoryForTextLog();
            using (var logFile = new StreamWriter(LogFilePath, true))
            {
                logFile.WriteLine(fatalLogString);
                logFile.Close();
            }
        }
    }
}
