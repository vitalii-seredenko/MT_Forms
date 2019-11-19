using MT_Forms.Core.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MT_Forms.PageObjects.Buttons
{
    internal class QuestsButtons
    {
        private readonly IWebDriver _driver;

        internal QuestsButtons()
        {
            _driver = DriverSingleton.Driver;
            PageFactory.InitElements(_driver, this);
        }

        #region WebElements

        [FindsBy(How = How.XPath, Using = "//a[contains(., 'Найти банду')]")]
        internal IWebElement findGangButton;
        [FindsBy(How = How.XPath, Using = "//a[contains(., 'Продолжить приключения')]")]
        internal IWebElement continueAdventures;

        #endregion
    }
}