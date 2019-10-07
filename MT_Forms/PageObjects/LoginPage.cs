using MT_Forms.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MT_Forms.PageObjects
{
    internal class LoginPage
    {
        private readonly IWebDriver _driver;
        public LoginPage()
        {
            _driver = DriverSingleton.Driver;
            PageFactory.InitElements(_driver, this);
        }

        #region WebElements

        [FindsBy(How = How.XPath, Using = "//a[@title='Войти']//span[@class='go-btn-in']")]
        public IWebElement startGameButton;
        [FindsBy(How = How.XPath, Using = "//input[@id='login']")]
        public IWebElement inputLoginForm;
        [FindsBy(How = How.XPath, Using = "//input[@id='password']")]
        public IWebElement inputPasswordForm;
        [FindsBy(How = How.XPath, Using = "//input[@id='submit']")]
        public IWebElement submitButton;
        [FindsBy(How = How.XPath, Using = "//input[@id='captcha']")]
        public IWebElement captchaTextBox;
        [FindsBy(How = How.XPath, Using = "//span[@class='feedbackPanelERROR' and text()='Введен неверный код']")]
        public IWebElement invalidCaptchaErrorMessage;
        [FindsBy(How = How.XPath, Using = "//span[@class='feedbackPanelERROR' and contains(text(), 'Неверное имя или пароль')]")]
        public IWebElement invalidLoginOrPasswordErrorMessage;

        #endregion

        #region CheckElementIsPresent

        public bool CheckInvalidLoginOrPasswordErrorMessageIsPresent()
        {
            try
            {
                return invalidLoginOrPasswordErrorMessage.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
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

        public bool CheckСaptchaTextBoxIsPresent()
        {
            try
            {
                return captchaTextBox.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        #endregion
    }
}

