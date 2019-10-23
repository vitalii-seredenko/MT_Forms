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
        private readonly Logger _logger;

        internal CaptchaProcessing()
        {
            _logger = new Logger();
            _baseTownPage = new BaseTownPage();
        }

        internal void CallCaptchaProcessingDialogWindow()
        {
            if (new LoginPage().СaptchaTextBoxIsPresent())
            {
                FormsInitialization.captchaProcessingForm.ShowDialog();
            }
        }

        internal void ProcessingCaptcha()
        {
            var loginPage = new LoginPage();
            loginPage.captchaTextBox.SendKeys(Keys.Control + "a");
            loginPage.captchaTextBox.SendKeys(captcha);
            loginPage.submitButton.Click();
            if (loginPage.InvalidCaptchaErrorMessageIsPresent())
            {
                MessageBox.Show("Введите капчу заново!", "Ошибка");
                _logger.Error("User entered an invalid captcha");
            }
            CloseCaptchaProcessingDialogWindow();
        }

        internal void CloseCaptchaProcessingDialogWindow()
        {
            if (_baseTownPage.CityPictureIsPresent())
            {
                _baseTownPage.GetHeroesHealth();
                FormsInitialization.captchaProcessingForm.Hide();
            }
        }
    }
}
