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
        private readonly IWebDriver _driver;
        public Form1()
        {
            _driver = DriverSingletone.Driver;
            InitializeComponent();
        }

        public CheckBox GoForTheCasketCheckBox => goForTheCasketCheckBox;
        public CheckBox GoForTheCasketAndToEndCheckBox => goForTheCasketAndToEndCheckBox;

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
            new VysokaiaTemnitsa().VysokaiaTemnitsaScript();
        }

        private void goForTheCasketCheckBox_Click(object sender, EventArgs e)
        {
            goForTheCasketCheckBox.CheckState = CheckState.Checked;
            goForTheCasketAndToEndCheckBox.CheckState = CheckState.Unchecked;
        }

        private void goForTheCasketAndToEndCheckBox_Click(object sender, EventArgs e)
        {
            goForTheCasketAndToEndCheckBox.CheckState = CheckState.Checked;
            goForTheCasketCheckBox.CheckState = CheckState.Unchecked;
        }
    }
}
