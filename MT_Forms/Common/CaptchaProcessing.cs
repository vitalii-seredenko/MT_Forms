using System.Windows.Forms;
using MT_Forms.Core;
using MT_Forms.Core.Logger;
using MT_Forms.Extensions;
using MT_Forms.PageObjects.WebPages;
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
            if (new LoginPage().captchaTextBox.IsElementPresent())
            {
                FormsStorage.captchaProcessingForm.ShowDialog();
            }
        }

        internal void ProcessingCaptcha()
        {
            var loginPage = new LoginPage();
            loginPage.captchaTextBox.WaitElement().SendKeys(Keys.Control + "a");
            loginPage.captchaTextBox.SendKeys(captcha);
            loginPage.submitButton.WaitElementAndClick();
            if (loginPage.invalidCaptchaErrorMessage.IsElementPresent())
            {
                MessageBox.Show("Введите капчу заново!", "Ошибка");
                _logger.Error("User entered an invalid captcha");
            }
            CloseCaptchaProcessingDialogWindow();
        }

        internal void CloseCaptchaProcessingDialogWindow()
        {
            var userCharacteristic = new UserCharacteristic();
            if (_baseTownPage.cityPicture.IsElementPresent())
            {
                userCharacteristic.GetUser();
                FormsStorage.captchaProcessingForm.Hide();
                FormsStorage.mainProgramForm.Show();
                FormsStorage.loginForm.Hide();
            }
        }
    }
}
