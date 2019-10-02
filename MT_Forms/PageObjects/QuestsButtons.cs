using Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PageObjects
{
    class QuestsButtons
    {
        private IWebDriver _driver;
        public QuestsButtons()
        {
            _driver = DriverSingletone.Driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[contains(., 'Найти банду')]")]
        public IWebElement findGangButton;
        [FindsBy(How = How.XPath, Using = "//a[contains(., 'Продолжить приключения')]")]
        public IWebElement continueAdventures;
    }
}