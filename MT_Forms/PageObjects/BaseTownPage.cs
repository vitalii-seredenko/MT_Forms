using MT_Forms.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MT_Forms.PageObjects
{
    class BaseTownPage
    {
        private readonly IWebDriver _driver;
        private int _heroesHealth;

        public BaseTownPage()
        {
            _driver = DriverSingleton.Driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[contains(@class, 'go-btn') && not(*[contains(., 'В подземелье')])]")]
        public IWebElement continueButton;
        [FindsBy(How = How.XPath, Using = "//div[@class='billboard _promo']")]
        public IWebElement billboardElement;
        [FindsBy(How = How.XPath, Using = "//a[@class='popup-close']")]
        public IWebElement closePopUpButton;
        [FindsBy(How = How.XPath, Using = "//img[@alt='Мир Теней']")]
        public IWebElement cityPicture;
        [FindsBy(How = How.XPath, Using = "//span[@class='info']")]
        public IWebElement heroesHealthTextBox;

        public bool CheckContinueButtonIsPresent()
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

        public bool CheckBillboardElementIsPresent()
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

        public bool CheckCityPictureIsPresent()
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

        public void GetHeroesHealth()
        {
            _heroesHealth = int.Parse(heroesHealthTextBox.Text);
        }

        public bool CheckHeroesHealthLessThenTwentyPercent()
        {
            return _heroesHealth * 0.2 < int.Parse(heroesHealthTextBox.Text);
        }
    }
}
