using Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PageObjects
{
    class BaseTownPage
    {
        private IWebDriver _driver;
        public BaseTownPage()
        {
            _driver = DriverSingletone.Driver;
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
    }
}
