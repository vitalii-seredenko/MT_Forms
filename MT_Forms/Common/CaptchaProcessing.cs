using System.Windows.Forms;
using MT_Forms.Core;
using MT_Forms.PageObjects;
using Keys = OpenQA.Selenium.Keys;

namespace MT_Forms.Common
{
    internal class CaptchaProcessing
    {
        internal static string captcha;
        private readonly BaseTownPage _baseTownPage;

        internal CaptchaProcessing()
        {
            _baseTownPage = new BaseTownPage();
        }

        internal void CallCaptchaProcessingDialogWindow()
        {
            if (new LoginPage().CheckСaptchaTextBoxIsPresent())
            {
                FormsInitialization.form2.ShowDialog();
            }
        }

        internal void ProcessingCaptcha()
        {
            var loginPage = new LoginPage();
            loginPage.captchaTextBox.SendKeys(Keys.Control + "a");
            loginPage.captchaTextBox.SendKeys(captcha);
            loginPage.submitButton.Click();
            if (loginPage.CheckInvalidCaptchaErrorMessageIsPresent())
            {
                MessageBox.Show("Введите капчу заново!", "Ошибка");
            }
            CloseCaptchaProcessingDialogWindow();
        }

        internal void CloseCaptchaProcessingDialogWindow()
        {
            if (_baseTownPage.CheckCityPictureIsPresent())
            {
                _baseTownPage.GetHeroesHealth();
                FormsInitialization.form2.Hide();
            }
        }
    }
}
