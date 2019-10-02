using System;
using System.Windows.Forms;
using CommonMethods;
using Core;
using OpenQA.Selenium;
using PageObjects;
using Keys = OpenQA.Selenium.Keys;

namespace MT_Forms
{
    public partial class Form2 : Form
    {
        readonly IWebDriver _driver;
        public Form2()
        {
            _driver = DriverSingletone.Driver;
            InitializeComponent();
        }

        private void CaptchaTextBox_TextChanged(object sender, EventArgs e)
        {
            GoToUrl.captcha = captchaTextBox.Text;
        }

        private void EnterCaptchaButton_Click(object sender, EventArgs e)
        {
            //do
            //{
                new LoginPage(_driver).SendKeys(Keys.Control + "a");
                new LoginPage(_driver).SendKeys(GoToUrl.captcha);
                new LoginPage(_driver).submitButton.Click();
                if (new LoginPage(_driver).CheckInvalidCaptchaErrorMessageIsPresent())
                {
                    MessageBox.Show("Введите капчу заново!", "Ошибка");
                }
            //}
            //while (new LoginPage(driver).CheckInvalidCaptchaErrorMessageIsPresent());

            new Form2().Hide();
            
        }
    }
}
