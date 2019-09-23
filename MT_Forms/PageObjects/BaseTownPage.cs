using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace PageObjects
{
    class BaseTownPage
    {
        private IWebDriver _driver;
        public BaseTownPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        WebDriverWait explicitWait;

        [FindsBy(How = How.XPath, Using = "//span[text()='Облегченная версия']")] 
        public IWebElement lightVersionButton;
        [FindsBy(How = How.XPath, Using = "//a[contains(@class, 'go-btn') && not(*[contains(., 'В подземелье')])]")]
        public IWebElement continueButton;

        public bool checkContinueButtonIsPresent()
        {
            try
            {
                bool a = continueButton.Displayed;
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
