using System;
using System.Windows.Forms;
using MT_Forms.Common;

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
            if(!string.IsNullOrEmpty(Login.loginName) || !string.IsNullOrEmpty(Login.password))
                new Login().GoToMt();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Login.loginName) || !string.IsNullOrEmpty(Login.password))
                new Core.Application().DisposeDriver();
        }
    }
}
