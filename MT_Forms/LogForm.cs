using MT_Forms.Core;
using MT_Forms.Core.Logger;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MT_Forms
{
    public partial class LogForm : Form
    {
        private readonly Logger _logger = new Logger();
        private readonly List<string> _buttonsText = new List<string> { "Обновить", "Показать весь лог", "Только INFO", "Только ERROR", "Только FATAL" };
        private bool _showLogButtonWasClicked;
        private bool _showInfoLogButtonWasClicked;
        private bool _showErrorLogButtonWasClicked;
        private bool _showFatalLogButtonWasClicked;

        internal ListBox LogBox => logBox;

        public LogForm()
        {
            InitializeComponent();
            showLogButton.Click += ChangeLogButtonsTextIfButtonClicked;
            showInfoLogButton.Click += ChangeLogButtonsTextIfButtonClicked;
            showErrorLogButton.Click += ChangeLogButtonsTextIfButtonClicked;
            showFatalLogButton.Click += ChangeLogButtonsTextIfButtonClicked;
        }

        private void LogForm_Load(object sender, EventArgs e)
        {

        }

        private void ChangeLogButtonsTextIfButtonClicked(object sender, EventArgs e)
        {
            showLogButton.Text = _showLogButtonWasClicked ? _buttonsText[0] : _buttonsText[1];
            showInfoLogButton.Text = _showInfoLogButtonWasClicked ? _buttonsText[0] : _buttonsText[2];
            showErrorLogButton.Text = _showErrorLogButtonWasClicked ? _buttonsText[0] : _buttonsText[3];
            showFatalLogButton.Text = _showFatalLogButtonWasClicked ? _buttonsText[0] : _buttonsText[4];
            _showLogButtonWasClicked = _showInfoLogButtonWasClicked = _showErrorLogButtonWasClicked = _showFatalLogButtonWasClicked = false;
        }

        private void ShowLogButton_Click(object sender, EventArgs e)
        {
            _showLogButtonWasClicked = true;
            _logger.WriteAllLogInLogBox();
        }

        private void ShowInfoLogButton_Click(object sender, EventArgs e)
        {
            _showInfoLogButtonWasClicked = true;
            _logger.WriteInfoLogInLogBox();
        }

        private void ShowErrorLogButton_Click(object sender, EventArgs e)
        {
            _showErrorLogButtonWasClicked = true;
            _logger.WriteErrorLogInLogBox();
        }

        private void ShowFatalLogButton_Click(object sender, EventArgs e)
        {
            _showFatalLogButtonWasClicked = true;
            _logger.WriteFatalLogInLogBox();
        }

        private void LogForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormsStorage.logForm = new LogForm();
        }
    }
}
