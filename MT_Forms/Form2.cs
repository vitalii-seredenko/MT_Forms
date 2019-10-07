using System;
using System.Windows.Forms;
using MT_Forms.CommonMethods;
using MT_Forms.PageObjects;
using Keys = OpenQA.Selenium.Keys;

namespace MT_Forms
{
    public partial class Form2 : Form
    {
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
            var loginPage = new LoginPage();
            var baseTownPage = new BaseTownPage();
            loginPage.captchaTextBox.SendKeys(Keys.Control + "a");
            loginPage.captchaTextBox.SendKeys(GoToUrl.captcha);
            loginPage.submitButton.Click();
            if (loginPage.CheckInvalidCaptchaErrorMessageIsPresent())
            {
                MessageBox.Show("Введите капчу заново!", "Ошибка");
            }
            if (baseTownPage.CheckCityPictureIsPresent())
            {
                baseTownPage.GetHeroesHealth();
                GoToUrl.form2.Hide();
            }
        }
    }
}
