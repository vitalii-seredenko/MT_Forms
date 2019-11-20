using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace MT_Forms.Core.Driver
{
    internal class DriverFactory
    {
        internal IWebDriver GetDriver(Drivers driverName)
        {
           IWebDriver driver;

           switch (driverName)
            {
                case Drivers.Chrome:
                    driver = new ChromeDriver();
                    break;
                case Drivers.FireFox:
                    driver = new FirefoxDriver();
                    break;
                default:
                    throw new ArgumentException($"Driver {driverName} does not support");
            }
            return driver;
        }
    }
}