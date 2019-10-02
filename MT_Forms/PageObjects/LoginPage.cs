using Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PageObjects
{
    class LoginPage
    {
        private IWebDriver _driver;
        public LoginPage()
        {
            _driver = DriverSingletone.Driver;
            PageFactory.InitElements(_driver, this);
        }

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
        [FindsBy(How = How.XPath, Using = "//span[@class='feedbackPanelERROR' and text()='Введен неверный код']")]
        public IWebElement invalidCaptchaErrorMessage;

        public void SendKeys(string valueForInput)
        {
            captchaTextBox.SendKeys(valueForInput);
        }

        public bool CheckInvalidCaptchaErrorMessageIsPresent()
        {
            try
            {
                return invalidCaptchaErrorMessage.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}

