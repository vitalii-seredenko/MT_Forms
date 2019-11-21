using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MT_Forms.PageObjects.Buttons
{
    internal class QuestsButtons : Buttons
    {
        internal QuestsButtons()
        {
            PageFactory.InitElements(driver, this);
        }

        #region WebElements

        [FindsBy(How = How.XPath, Using = "//a[contains(., 'Найти банду')]")]
        internal IWebElement findGangButton;
        [FindsBy(How = How.XPath, Using = "//a[contains(., 'Продолжить приключения')]")]
        internal IWebElement continueAdventures;

        #endregion
    }
}