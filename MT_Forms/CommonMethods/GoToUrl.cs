using Core;
using MT_Forms;
using OpenQA.Selenium;
using PageObjects;

namespace CommonMethods
{
    class GoToUrl
    {
        IWebDriver driver;
        LoginPage loginPage;
        BaseTownPage baseTownPage;
        public static string loginName; //Друг Инженера
        public static string password;  //paleksanov4194
        public static string captcha;  

        public GoToUrl()
        {
            driver = DriverSingletone.Driver;
            loginPage = new LoginPage(driver);
            baseTownPage = new BaseTownPage(driver);
        }

        public void NavigateToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void GoToMt()
        {
            driver.Manage().Window.Maximize();
            NavigateToUrl("https://m.vten.ru/");
            loginPage.startGameButton.Click();
            Login();
        }

        public void Login()
        {
            loginPage.inputLogin.SendKeys(loginName);
            loginPage.inputPassword.SendKeys(password);
            loginPage.submitButton.Click();
            CaptchaProcessing();
        }

        public void CaptchaProcessing()
        {
            if (loginPage.captchaTextBox.Displayed)
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
        }
    }
}
