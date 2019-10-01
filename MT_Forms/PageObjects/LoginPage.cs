using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace PageObjects
{
    class LoginPage
    {
        private IWebDriver _driver;
        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }
        public LoginPage() { }

        WebDriverWait explicitWait;

        [FindsBy(How = How.XPath, Using = "//span[@class='go-btn-in']")]
        public IWebElement startGameButton;
        [FindsBy(How = How.XPath, Using = "//input[@id='login']")]
        public IWebElement inputLogin;
        [FindsBy(How = How.XPath, Using = "//input[@id='password']")]
        public IWebElement inputPassword;
        [FindsBy(How = How.XPath, Using = "//input[@id='submit']")]
        public IWebElement submitButton;
        [FindsBy(How = How.XPath, Using = "//input[@id='captcha']")]
        public IWebElement captchaTextBox;

        public void SendKeys(string valueForInput)
        {
            captchaTextBox.SendKeys(valueForInput);
        }
    }
}

