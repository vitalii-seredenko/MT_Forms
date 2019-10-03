using Core;
using MT_Forms;
using MT_Forms.PageObjects;
using OpenQA.Selenium;
using PageObjects;
using System.Windows.Forms;
using Keys = OpenQA.Selenium.Keys;

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

        public GoToUrl()
        {
            _driver = DriverSingletone.Driver;
            _loginPage = new LoginPage();
        }

        public void NavigateToUrl(string url)
        {
            _driver.Navigate().GoToUrl(url);
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
                MessageBox.Show("Неверный имя или пароль!", "Ошибка");
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
