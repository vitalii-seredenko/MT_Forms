using MT_Forms.Core.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MT_Forms.PageObjects.WebPages
{
    internal class GeneralBasePage
    {
        protected readonly IWebDriver driver;

        internal GeneralBasePage()
        {
             driver = DriverSingleton.Driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//span[text()='Облегченная версия']")]
        internal IWebElement lightVersionButton;
    }
}
