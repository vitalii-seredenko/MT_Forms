using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace MT_Forms.Core
{
    internal class DriverFactory
    {
        internal IWebDriver GetDriver(string driverName)
        {
            IWebDriver driver;

            switch (driverName)
            {
                case "chrome":
                    {
                        driver = new ChromeDriver();
                        break;
                    }
                case "firefox":
                    {
                        driver = new FirefoxDriver();
                        break;
                    }
                default:
                    throw new ArgumentOutOfRangeException(driverName, $"Driver {driverName} does not support");
            }
            return driver;
        }
    }
}