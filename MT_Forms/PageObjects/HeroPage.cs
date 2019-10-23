using MT_Forms.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MT_Forms.PageObjects
{
    internal class HeroPage
    {
        private readonly IWebDriver _driver;

        internal HeroPage()
        {
            _driver = DriverSingleton.Driver;
            PageFactory.InitElements(_driver, this);
        }

        #region WebElements

        [FindsBy(How = How.XPath, Using = "//ol[@class='mt3']/li[./span[contains(., 'Живучесть')]]/span[2]")]
        internal IWebElement heroHealthTextBox;
        [FindsBy(How = How.XPath, Using = "//ol[@class='mt3']/li[./span[contains(., 'Сила')]]/span[2]")]
        internal IWebElement heroStrangeTextBox;
        [FindsBy(How = How.XPath, Using = "//ol[@class='mt3']/li[./span[contains(., 'Крит')]]/span[3]")]
        internal IWebElement heroCriticalDamageTextBox;
        [FindsBy(How = How.XPath, Using = "//ol[@class='mt3']/li[./span[contains(., 'Защита от чёрной магии')]]/span[2]")]
        internal IWebElement heroBlackMagicProtectionTextBox;
        [FindsBy(How = How.XPath, Using = "//ol[@class='mt3']/li[./span[contains(., 'Регенерация')]]/span[2]")]
        internal IWebElement heroRegenerationTextBox;

        #endregion
    }
}