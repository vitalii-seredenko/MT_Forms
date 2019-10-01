using System;
using System.Drawing;
using System.Windows.Forms;
using CommonMethods;
using Core;
using OpenQA.Selenium;
using PageObjects;

namespace MT_Forms
{
    public partial class Form2 : Form
    {
        IWebDriver driver = DriverSingletone.Driver;
        public Form2()
        {
            InitializeComponent();
        }

        private void CaptchaTextBox_TextChanged(object sender, EventArgs e)
        {
            GoToUrl.captcha = captchaTextBox.Text;
        }

        private void EnterCaptchaButton_Click(object sender, EventArgs e)
        {
            new LoginPage(driver).SendKeys(GoToUrl.captcha);
            new Form2().Dispose();
            new LoginPage(driver).submitButton.Click();
            new BaseTownPage(driver).SwitchToLightVersion();
        }
    }
}
