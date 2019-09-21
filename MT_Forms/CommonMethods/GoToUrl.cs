using Core;
using OpenQA.Selenium;
using PageObjects;

namespace CommonMethods
{
    class GoToUrl
    {
        IWebDriver driver;
        LoginPage loginPage;
        BaseTownPage baseTownPage;

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

        public void LoginToMt()
        {
            driver.Manage().Window.Maximize();
            NavigateToUrl("https://m.vten.ru/");
            loginPage.startGameButton.Click();
            loginPage.inputLogin.SendKeys("Друг Инженера");
            loginPage.inputPassword.SendKeys("paleksanov4194");
            loginPage.submitButton.Click();
            baseTownPage.lightVersionButton.Click();
        }
    }
}
