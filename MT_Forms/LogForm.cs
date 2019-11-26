using System;
using System.Windows.Forms;
using MT_Forms.Core;
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
            showLogButton.Text = "Обновить";
            showInfoLogButton.Text = "Только INFO";
            showErrorLogButton.Text = "Только ERROR";
            showFatalLogButton.Text = "Только FATAL";
        }

        private void ShowInfoLogButton_Click(object sender, EventArgs e)
        {
            _logger.WriteInfoLogInLogBox();
            showLogButton.Text = "Показать весь лог";
            showInfoLogButton.Text = "Обновить";
            showErrorLogButton.Text = "Только ERROR";
            showFatalLogButton.Text = "Только FATAL";
        }

        private void ShowErrorLogButton_Click(object sender, EventArgs e)
        {
            _logger.WriteErrorLogInLogBox();
            showLogButton.Text = "Показать весь лог";
            showInfoLogButton.Text = "Только INFO";
            showErrorLogButton.Text = "Обновить";
            showFatalLogButton.Text = "Только FATAL";
        }

        private void ShowFatalLogButton_Click(object sender, EventArgs e)
        {
            _logger.WriteFatalLogInLogBox();
            showLogButton.Text = "Показать весь лог";
            showInfoLogButton.Text = "Только INFO";
            showErrorLogButton.Text = "Только ERROR";
            showFatalLogButton.Text = "Обновить";
        }

        private void LogForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormsStorage.logForm = new LogForm();
        }
    }
}
