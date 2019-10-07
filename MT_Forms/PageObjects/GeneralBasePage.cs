using Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MT_Forms.PageObjects
{
    class GeneralBasePage
    {
        private IWebDriver _driver;
        public GeneralBasePage()
        {
             _driver = DriverSingletone.Driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//span[text()='Облегченная версия']")]
        public IWebElement lightVersionButton;

        public void SwitchToLightVersion()
        {
            lightVersionButton.Click();
        }

        public bool CheckLightVersionButtonIsPresent()
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
