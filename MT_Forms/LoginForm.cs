using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using MT_Forms.Common;
using MT_Forms.Core;

namespace MT_Forms
{
    internal partial class LoginForm : Form
    {
        internal LoginForm()
        {
            InitializeComponent();
        }

        private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {
            Login.loginName = loginTextBox.Text;
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            Login.password = passwordTextBox.Text;
        }

        private void GoToMTButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Login.loginName) || !string.IsNullOrEmpty(Login.password))
            {
                new Login().GoToMt();
            }
            else
            {
                toolTipForButtons.SetToolTip(goToMTButton, "Сперва заполните пустые поля!");
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            FormsStorage.loginForm.Dispose();
        }

        private void HelpButton_Click(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBox.Show("Автор: m_dsst\n\n            2019", "О программе");
            //FormsStorage.loginForm.Cursor = Cursors.Arrow;
        }

        private void ShowOrHideLogButton_Click(object sender, EventArgs e)
        {
            if (!FormsStorage.logForm.Visible)
            {
                var workerThread = new Thread(() => Application.Run(FormsStorage.logForm));
                workerThread.Start();
            }
        }
    }
}
