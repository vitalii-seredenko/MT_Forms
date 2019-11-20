using System;
using System.Windows.Forms;
using MT_Forms.Core.Logger;

namespace MT_Forms
{
    public partial class LogForm : Form
    {
        internal ListBox LogBox => logBox;

        public LogForm()
        {
            InitializeComponent();
        }

        private void ShowLogButton_Click(object sender, EventArgs e)
        {
            Logger.WriteAllLogInLogBox();
        }

        private void ShowInfoLogButton_Click(object sender, EventArgs e)
        {
            Logger.WriteInfoLogInLogBox();
        }

        private void ShowErrorLogButton_Click(object sender, EventArgs e)
        {
            Logger.WriteErrorLogInLogBox();
        }

        private void ShowFatalLogButton_Click(object sender, EventArgs e)
        {
            Logger.WriteFatalLogInLogBox();
        }
    }
}
