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

           var service = ChromeDriverService.CreateDefaultService();
           var options = new ChromeOptions();
           service.HideCommandPromptWindow = true;
           options.AddArguments("start-maximized");

           switch (driverName)
           {
                case Drivers.Chrome:
                    driver = new ChromeDriver(service, options);
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