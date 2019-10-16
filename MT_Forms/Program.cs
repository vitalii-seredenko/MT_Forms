using System;
using MT_Forms.Core;

namespace MT_Forms
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            var _logger = new Logger();
            _logger.Info("<-----------New application session started----------->");

            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(Logger.WriteLogInLogBox);
            timer.Start();

            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.Run(FormsInitialization.form1);
            _logger.Info("<-----------Application finished----------->\n");
        }
    }
}
