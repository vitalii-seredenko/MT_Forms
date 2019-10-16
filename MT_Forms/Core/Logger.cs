using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Timers;

namespace MT_Forms.Core
{
    internal class Logger
    {
        //private static TimeSpan startTimeSpan = TimeSpan.Zero;
        //private static TimeSpan periodTimeSpan = TimeSpan.FromSeconds(1);
        private static List<string> logList= new List<string>();
        private static readonly string logFilePath = $"{Environment.CurrentDirectory}\\logs\\{DateTime.Now.ToShortDateString()}.txt";
        private StreamWriter logFile = new StreamWriter(logFilePath, true);

        //private static Timer callWriteLogInLogBox = new Timer((e) =>
        //{
        //    WriteLogInLogBox();
        //}, null, startTimeSpan, periodTimeSpan);

        internal static void WriteLogInLogBox(object sender, ElapsedEventArgs e)
        {
            foreach (var logMessage in logList)
            {
                FormsInitialization.form1.LogBox.Text = logMessage;
            }
        }

        internal void Info(string logString)
        {          
            var infoLogString = $"{DateTime.Now.ToLocalTime()} | INFO | {logString}";
            logList.Add(infoLogString);
            logFile.WriteLine(infoLogString);
            if(logString.Contains("Application finished"))
                logFile.Close();
        }

        internal void Error(string logString)
        {
            var errorLogString = $"{DateTime.Now.ToLocalTime()} | ERROR | {logString}";
            logList.Add(errorLogString);
            logFile.WriteLine(errorLogString);
            if (logString.Contains("Application finished"))
                logFile.Close();
        }

        internal void Fatal(string logString)
        {
            var fatalLogString = $"{DateTime.Now.ToLocalTime()} | FATAL | {logString}";
            logList.Add(fatalLogString);
            logFile.WriteLine(fatalLogString);
            if (logString.Contains("Application finished"))
                logFile.Close();
        }
    }
}
