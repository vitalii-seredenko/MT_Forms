using System;
using MT_Forms.Core;
using NLog;

namespace MT_Forms
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            var log = LogManager.GetCurrentClassLogger();
            log.Info("<-----------New application session started----------->");
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.Run(FormsInitialization.form1);
            log.Info("<-----------Application finished----------->\n");
        }
    }
}
