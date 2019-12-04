using MT_Forms.Core.Driver;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MT_Forms.PageObjects.WebPages
{
    internal class GeneralBasePage
    {
        protected readonly IWebDriver driver = DriverSingleton.Driver;

        internal GeneralBasePage()
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//span[text()='Облегченная версия']")]
        internal IWebElement lightVersionButton;
    }
}
