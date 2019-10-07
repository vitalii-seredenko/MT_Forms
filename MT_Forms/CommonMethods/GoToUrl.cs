using System.Windows.Forms;
using MT_Forms.Core;
using MT_Forms.PageObjects;
using NLog;
using OpenQA.Selenium;
using Keys = OpenQA.Selenium.Keys;

namespace MT_Forms.CommonMethods
{
    class GoToUrl
    {
        public static string loginName; //Друг Инженера
        public static string password;  //paleksanov4194
        public static string captcha;
        public static Form2 form2 = new Form2();
        private Logger _log = LogManager.GetCurrentClassLogger();
        private readonly IWebDriver _driver;
        private readonly LoginPage _loginPage;

        public GoToUrl()
        {
            _driver = DriverSingleton.Driver;
            _loginPage = new LoginPage();
        }

        public void NavigateToUrl(string url)
        {
            _driver.Navigate().GoToUrl(url);
            _log.Info($"User navigates to '{url}'");
        }

        public void GoToMt()
        {
            GeneralBasePage generalBasePage = new GeneralBasePage();
            _driver.Manage().Window.Maximize();
            NavigateToUrl("https://m.vten.ru/");
            _loginPage.startGameButton.Click();
            if (generalBasePage.CheckLightVersionButtonIsPresent())
            {
                generalBasePage.SwitchToLightVersion();
            }
            Login();
            _log.Info("Program successfully logged in MT");
        }

        public void Login()
        {
            _loginPage.inputLoginForm.SendKeys(Keys.Control + "a");
            _loginPage.inputLoginForm.SendKeys(loginName);
            _loginPage.inputPasswordForm.SendKeys(Keys.Control + "a");
            _loginPage.inputPasswordForm.SendKeys(password);
            _loginPage.submitButton.Click();
            CallCaptchaProcessingDialogWindow();
            if (_loginPage.CheckInvalidLoginOrPasswordErrorMessageIsPresent())
            {
                MessageBox.Show("Неверное имя или пароль!", "Ошибка");
            }
        }

        public void CallCaptchaProcessingDialogWindow()
        {
            if (_loginPage.CheckСaptchaTextBoxIsPresent())
            {
                form2.ShowDialog();
            }
        }
    }
}
