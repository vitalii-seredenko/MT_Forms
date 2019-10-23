using System.Windows.Forms;
using MT_Forms.Core;
using MT_Forms.PageObjects;
using Keys = OpenQA.Selenium.Keys;

namespace MT_Forms.Common
{
    internal class Login
    {
        internal static string loginName; //Друг Инженера
        internal static string password;  //paleksanov4194
        private readonly LoginPage _loginPage;
        private readonly Logger _logger;

        internal Login()
        {
            _logger = new Logger();
            _loginPage = new LoginPage();
        }

        internal void GoToMt()
        {
            var generalBasePage = new GeneralBasePage();
            new Core.Application().MaximizeBrowserWindow();
            new Core.Application().NavigateToUrl("https://m.vten.ru/");
            _loginPage.startGameButton.Click();
            if (generalBasePage.LightVersionButtonIsPresent())
            {
                generalBasePage.SwitchToLightVersion();
            }
            LoginWithParameters();
            new Logger().Info("Program successfully logged in MT");
        }

        internal void LoginWithParameters()
        {
            _loginPage.inputLoginForm.SendKeys(Keys.Control + "a");
            _loginPage.inputLoginForm.SendKeys(loginName);
            _loginPage.inputPasswordForm.SendKeys(Keys.Control + "a");
            _loginPage.inputPasswordForm.SendKeys(password);
            _loginPage.submitButton.Click();
            new CaptchaProcessing().CallCaptchaProcessingDialogWindow();
            if (_loginPage.InvalidLoginOrPasswordErrorMessageIsPresent())
            {
                MessageBox.Show("Неверное имя или пароль!", "Ошибка");
                _logger.Error("User entered an invalid username or password");
            }
        }
    }
}