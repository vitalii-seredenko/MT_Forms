using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MT_Forms.PageObjects.WebPages
{
    internal class BaseTownPage : GeneralBasePage
    {
        private int _heroesHealth;

        internal BaseTownPage()
        {
            PageFactory.InitElements(driver, this);
        }

        #region WebElements

        [FindsBy(How = How.XPath, Using = "//a[contains(@class, 'go-btn') && not(*[contains(., 'В подземелье')])]")]
        internal IWebElement continueButton;
        [FindsBy(How = How.XPath, Using = "//div[@class='billboard _promo']")]
        internal IWebElement billboardElement;
        [FindsBy(How = How.XPath, Using = "//a[@class='popup-close']")]
        internal IWebElement closePopUpButton;
        [FindsBy(How = How.XPath, Using = "//img[@alt='Мир Теней']")]
        internal IWebElement cityPicture;
        [FindsBy(How = How.XPath, Using = "//span[@class='info']")]
        internal IWebElement heroesHealthTextBox;
        [FindsBy(How = How.XPath, Using = "//a[@href='https://m.vten.ru/user']")]
        internal IWebElement characterButton;

        #endregion

        #region Methods

        internal void GetHeroesHealth()
        {
            _heroesHealth = int.Parse(heroesHealthTextBox.Text);
        }

        internal bool CheckHeroesHealthLessThenTwentyPercent()
        {
            return _heroesHealth * 0.2 < int.Parse(heroesHealthTextBox.Text);
        }

        #endregion
    }
}
