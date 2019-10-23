using MT_Forms.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MT_Forms.PageObjects
{
    internal class BaseTownPage
    {
        private readonly IWebDriver _driver;
        private int _heroesHealth;

        internal BaseTownPage()
        {
            _driver = DriverSingleton.Driver;
            PageFactory.InitElements(_driver, this);
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

        #endregion

        #region CheckElementIsPresent

        internal bool ContinueButtonIsPresent()
        {
            try
            {
                return continueButton.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        internal bool BillboardElementIsPresent()
        {
            try
            {
                return billboardElement.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        internal bool CityPictureIsPresent()
        {
            try
            {
                return cityPicture.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        #endregion

        internal void GetHeroesHealth()
        {
            _heroesHealth = int.Parse(heroesHealthTextBox.Text);
        }

        internal bool CheckHeroesHealthLessThenTwentyPercent()
        {
            return _heroesHealth * 0.2 < int.Parse(heroesHealthTextBox.Text);
        }
    }
}
