using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using POMExample.Core;

namespace POMExample.PageObjects
{
    internal class SiteHeader
    {
        protected readonly IWebDriver Driver = DriverSingleton.Driver;
        protected readonly Actions Actions;

        internal SiteHeader()
        {
            PageFactory.InitElements(Driver, this);
            Actions = new Actions(Driver);
        }

        #region WebElements

        [FindsBy(How = How.XPath, Using = "//img[@src='https://i.rozetka.ua/design/logo-dark.svg']")]
        private IWebElement logoIcon;

        [FindsBy(How = How.XPath, Using = "//input[@class='rz-header-search-input-text passive']")]
        private IWebElement searchInput;

        #endregion

        #region Methods

        internal void AssertPage(string pageUrl)
        {
            Assert.AreEqual(pageUrl, Driver.Url, $"Is not a correct page! Expected page is '{pageUrl}' but actual is '{Driver.Url}'");
        }

        #endregion
    }
}
