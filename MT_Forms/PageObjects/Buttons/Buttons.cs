using MT_Forms.Core.Driver;
using OpenQA.Selenium;

namespace MT_Forms.PageObjects.Buttons
{
    internal abstract class Buttons
    {
        protected readonly IWebDriver driver;

        internal Buttons()
        {
            driver = DriverSingleton.Driver;
        }
    }
}
