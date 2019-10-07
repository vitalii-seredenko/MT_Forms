using MT_Forms.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MT_Forms.PageObjects
{
    class QuestsButtons
    {
        private readonly IWebDriver _driver;
        public QuestsButtons()
        {
            _driver = DriverSingleton.Driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[contains(., 'Найти банду')]")]
        public IWebElement findGangButton;
        [FindsBy(How = How.XPath, Using = "//a[contains(., 'Продолжить приключения')]")]
        public IWebElement continueAdventures;
    }
}