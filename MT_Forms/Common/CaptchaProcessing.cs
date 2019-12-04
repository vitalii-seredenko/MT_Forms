using MT_Forms.Core;
using MT_Forms.Core.Logger;
using MT_Forms.Extensions;
using MT_Forms.PageObjects.WebPages;
using System.Windows.Forms;
using MT_Forms.LogicForCharacters;
using Keys = OpenQA.Selenium.Keys;

namespace MT_Forms.Common
{
    internal class CaptchaProcessing
    {
        internal static string captcha;
        private readonly BaseTownPage _baseTownPage;
        private readonly LoginPage _loginPage;
        private readonly Logger _logger;

        internal CaptchaProcessing()
        {
            _logger = new Logger();
            _baseTownPage = new BaseTownPage();
            _loginPage = new LoginPage();
        }

        internal void CallCaptchaProcessingDialogWindow()
        {
            if (_loginPage.captchaTextBox.IsElementPresent())
            {
                FormsStorage.captchaProcessingForm.ShowDialog();
            }
        }

        internal void ProcessingCaptcha()
        {
            _loginPage.captchaTextBox.WaitElement().SendKeys(Keys.Control + "a");
            _loginPage.captchaTextBox.SendKeys(captcha);
            _loginPage.submitButton.WaitElementAndClick();
            if (_loginPage.invalidCaptchaErrorMessage.IsElementPresent())
            {
                MessageBox.Show("Введите капчу заново!", "Ошибка");
                _logger.Error("User entered an invalid captcha");
            }
            CloseCaptchaProcessingDialogWindow();
        }

        internal void CloseCaptchaProcessingDialogWindow()
        {
            if (_baseTownPage.cityPicture.IsElementPresent())
            {
                new UserCharacteristic().GetUser();
                FormsStorage.captchaProcessingForm.Hide();
                FormsStorage.mainProgramForm.Show();
                FormsStorage.loginForm.Hide();
            }
        }
    }
}
