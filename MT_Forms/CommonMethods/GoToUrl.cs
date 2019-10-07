using Core;
using MT_Forms;
using MT_Forms.PageObjects;
using NLog;
using OpenQA.Selenium;
using PageObjects;

namespace CommonMethods
{
    class GoToUrl
    {
        readonly IWebDriver _driver;
        readonly LoginPage _loginPage;
        public static string loginName; //Друг Инженера
        public static string password;  //paleksanov4194
        public static string captcha;  
        public static Form2 form2 = new Form2();
        private Logger _log = LogManager.GetCurrentClassLogger();

        public GoToUrl()
        {
            _driver = DriverSingletone.Driver;
            _loginPage = new LoginPage();
        }

        public void NavigateToUrl(string url)
        {
            _driver.Navigate().GoToUrl(url);
            _log.Info($"User navigates to '{url}'");
        }

        public void GoToMt()
        {
            _driver.Manage().Window.Maximize();
            NavigateToUrl("https://m.vten.ru/");
            _loginPage.startGameButton.Click();
            new GeneralBasePage().SwitchToLightVersion();
            Login();
            _log.Info("Program successfully logged in MT");
        }

        public void Login()
        {
            _loginPage.inputLogin.SendKeys(loginName);
            _loginPage.inputPassword.SendKeys(password);
            _loginPage.submitButton.Click();
            CallCaptchaProcessingDialogWindow();
        }

        public void CallCaptchaProcessingDialogWindow()
        {
            if (_loginPage.captchaTextBox.Displayed)
            {
                form2.ShowDialog();
            }
        }
    }
}
