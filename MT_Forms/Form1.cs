using System;
using System.Windows.Forms;
using MT_Forms.CommonMethods;
using MT_Forms.Core;
using MT_Forms.Scripts;
using OpenQA.Selenium;

namespace MT_Forms
{
    internal partial class Form1 : Form
    {
        internal Form1()
        {
            InitializeComponent();
        }

        internal CheckBox GoForTheCasketCheckBox => goForTheCasketCheckBox;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {
            GoToUrl.loginName = loginTextBox.Text;
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            GoToUrl.password = passwordTextBox.Text;
        }

        private void GoToMTButton_Click(object sender, EventArgs e)
        {
            new GoToUrl().GoToMt();
        }

        private void VisokayaTemnitsaButton_Click(object sender, EventArgs e)
        {
            new VisokaiaTemnitsa().VisokaiaTemnitsaScript();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DriverSingleton.DisposeDriver();
        }
    }
}
