using System;
using MT_Forms.Core;

namespace MT_Forms
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            var logger = new Logger();
            logger.Info("<-----------New application session started----------->");
            System.Windows.Forms.Application.EnableVisualStyles();
            //System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(FormsInitialization.loginForm);
            logger.Info("<-----------Application finished----------->\n");
        }
    }
}
