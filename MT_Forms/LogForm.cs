using System;
using System.Windows.Forms;
using MT_Forms.Core.Logger;

namespace MT_Forms
{
    public partial class LogForm : Form
    {
        private readonly Logger _logger = new Logger();

        internal ListBox LogBox => logBox;

        public LogForm()
        {
            InitializeComponent();
        }

        private void ShowLogButton_Click(object sender, EventArgs e)
        {
            _logger.WriteAllLogInLogBox();
        }

        private void ShowInfoLogButton_Click(object sender, EventArgs e)
        {
            _logger.WriteInfoLogInLogBox();
        }

        private void ShowErrorLogButton_Click(object sender, EventArgs e)
        {
            _logger.WriteErrorLogInLogBox();
        }

        private void ShowFatalLogButton_Click(object sender, EventArgs e)
        {
            _logger.WriteFatalLogInLogBox();
        }
    }
}
