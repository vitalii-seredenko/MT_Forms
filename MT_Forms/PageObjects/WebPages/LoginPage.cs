using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MT_Forms.PageObjects.WebPages
{
    internal class LoginPage : GeneralBasePage
    {
        internal LoginPage()
        {
            PageFactory.InitElements(driver, this);
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

        #region Methods

       

        #endregion
    }
}

