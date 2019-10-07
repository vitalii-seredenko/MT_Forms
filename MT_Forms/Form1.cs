using System;
using System.Windows.Forms;
using CommonMethods;
using Core;
using OpenQA.Selenium;
using Scripts;

namespace MT_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public CheckBox GoForTheCasketCheckBox => goForTheCasketCheckBox;

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
            DriverSingletone.DisposeDriver();
        }
    }
}
