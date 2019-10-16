using MT_Forms.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MT_Forms.PageObjects
{
    internal class LoginPage
    {
        private readonly IWebDriver _driver;

        internal LoginPage()
        {
            _driver = DriverSingleton.Driver;
            PageFactory.InitElements(_driver, this);
        }

        #region WebElements

        [FindsBy(How = How.XPath, Using = "//a[@title='Войти']//span[@class='go-btn-in']")]
        internal IWebElement startGameButton;
        [FindsBy(How = How.XPath, Using = "//input[@id='login']")]
        internal IWebElement inputLoginForm;
        [FindsBy(How = How.XPath, Using = "//input[@id='password']")]
        internal IWebElement inputPasswordForm;
        [FindsBy(How = How.XPath, Using = "//input[@id='submit']")]
        internal IWebElement submitButton;
        [FindsBy(How = How.XPath, Using = "//input[@id='captcha']")]
        internal IWebElement captchaTextBox;
        [FindsBy(How = How.XPath, Using = "//span[@class='feedbackPanelERROR' and text()='Введен неверный код']")]
        internal IWebElement invalidCaptchaErrorMessage;
        [FindsBy(How = How.XPath, Using = "//span[@class='feedbackPanelERROR' and contains(text(), 'Неверное имя или пароль')]")]
        internal IWebElement invalidLoginOrPasswordErrorMessage;

        #endregion

        #region CheckElementIsPresent

        internal bool CheckInvalidLoginOrPasswordErrorMessageIsPresent()
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

        internal bool CheckInvalidCaptchaErrorMessageIsPresent()
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

        internal bool CheckСaptchaTextBoxIsPresent()
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

