using System;
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

        private void Form1_Load(object sender, EventArgs e)
        {

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
                toolTip1.SetToolTip(goToMTButton, "Введите имя персонажа и пароль!");
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
    }
}
