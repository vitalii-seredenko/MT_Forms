using System;
using System.Windows.Forms;
using NLog;

namespace MT_Forms
{
    static class Program
    {
        private static Logger _log = LogManager.GetCurrentClassLogger();

        [STAThread]
        static void Main()
        {
            _log.Info("<-----------New application started----------->");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
