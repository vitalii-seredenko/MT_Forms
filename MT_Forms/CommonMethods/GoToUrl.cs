using Core;
using OpenQA.Selenium;
using System;

namespace CommonMethods
{
    class GoToUrl
    {
        IWebDriver driver = DriverSingletone.Driver;

        public void NavigateToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
    }
}
