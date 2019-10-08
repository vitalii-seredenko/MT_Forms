using System;
using System.Windows.Forms;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            _log.Info("<-----------Application finished----------->\n");
        }
    }
}
