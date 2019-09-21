using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace PageObjects
{
    class QuestsButtons
    {
        private IWebDriver _driver;
        public QuestsButtons(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        WebDriverWait explicitWait;

        [FindsBy(How = How.XPath, Using = "//a[contains(., 'Найти банду')]")]
        public IWebElement findGangButton;
        [FindsBy(How = How.XPath, Using = "//a[contains(., 'Продолжить приключения')]")]
        public IWebElement continueAdventures;
    }
}