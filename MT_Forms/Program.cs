using System;
using System.Windows.Forms;
using MT_Forms.Core;
using MT_Forms.Core.Logger;

namespace MT_Forms
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            var logger = new Logger();
            logger.Info("<-----------New application session started----------->");
            Application.EnableVisualStyles();
            //System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(FormsStorage.loginForm);
            }
            catch (Exception exception)
            {
                logger.Fatal(exception.Message);
                MessageBox.Show("Возникла ошибка :(", "Fatal error");
                new MyApplication().DisposeDriver();
            }
            finally
            {
                logger.Info("<-----------------Application finished---------------->\n");
            }
        }
    }
}
