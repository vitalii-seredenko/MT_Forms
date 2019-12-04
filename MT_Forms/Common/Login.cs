using MT_Forms.ApplicationData;
using MT_Forms.Core.Logger;
using MT_Forms.Extensions;
using MT_Forms.PageObjects.WebPages;
using System.Windows.Forms;
using Keys = OpenQA.Selenium.Keys;

namespace MT_Forms.Common
{
    internal class Login
    {
        internal static string loginName; //Друг Инженера
        internal static string password;  //paleksanov4194
        private readonly LoginPage _loginPage = new LoginPage();
        private readonly Logger _logger = new Logger();

        internal void GoToMt()
        {
            var generalBasePage = new GeneralBasePage();
            var application = new Core.MyApplication();
            application.NavigateToUrl(CommonUrls.GameUrl);
            _loginPage.startGameButton.WaitElementAndClick();
            if (generalBasePage.lightVersionButton.IsElementPresent())
            {
                generalBasePage.lightVersionButton.WaitElementAndClick();
            }
            LoginWithParameters();
            _logger.Info("Program successfully logged in MT");
        }

        internal void LoginWithParameters()
        {
            _loginPage.inputLoginForm.WaitElement().SendKeys(Keys.Control + "a");
            _loginPage.inputLoginForm.SendKeys(loginName);
            _loginPage.inputPasswordForm.WaitElement().SendKeys(Keys.Control + "a");
            _loginPage.inputPasswordForm.SendKeys(password);
            _loginPage.submitButton.WaitElementAndClick();
            new CaptchaProcessing().CallCaptchaProcessingDialogWindow();
            if (_loginPage.invalidLoginOrPasswordErrorMessage.IsElementPresent())
            {
                MessageBox.Show("Неверное имя или пароль!", "Ошибка");
                _logger.Error("User entered an invalid username or password");
            }
        }
    }
}