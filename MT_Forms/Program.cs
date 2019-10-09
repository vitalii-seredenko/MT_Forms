using System;
using MT_Forms.Core;
using NLog;

namespace MT_Forms
{
    internal static class Program
    {
        private static Logger _log = LogManager.GetCurrentClassLogger();

        [STAThread]
        private static void Main()
        {
            _log.Info("<-----------New application session started----------->");
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.Run(FormsInitialization.form1);
            _log.Info("<-----------Application finished----------->\n");
        }
    }
}
