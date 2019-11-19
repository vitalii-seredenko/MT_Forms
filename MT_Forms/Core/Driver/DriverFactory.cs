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

           var co = new ChromeOptions();
           co.AddArgument("no-sandbox");

           switch (driverName)
            {
                case Drivers.Chrome:
                    driver = new ChromeDriver(co);
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