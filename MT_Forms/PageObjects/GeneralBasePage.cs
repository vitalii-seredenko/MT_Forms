using MT_Forms.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MT_Forms.PageObjects
{
    internal class GeneralBasePage
    {
        private readonly IWebDriver _driver;
        internal GeneralBasePage()
        {
             _driver = DriverSingleton.Driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//span[text()='Облегченная версия']")]
        internal IWebElement lightVersionButton;

        internal void SwitchToLightVersion()
        {
            lightVersionButton.Click();
        }

        internal bool CheckLightVersionButtonIsPresent()
        {
            try
            {
                return lightVersionButton.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
