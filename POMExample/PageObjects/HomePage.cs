using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using POMExample.Core;
using POMExample.TestData;

namespace POMExample.PageObjects
{
    internal class HomePage : SiteHeader
    {
        private readonly string _pageUrl = PageUrls.HomePageUrl;

        internal HomePage()
        {
            PageFactory.InitElements(Driver, this);
            AssertPage(_pageUrl);
        }

        #region WebElements

        [FindsBy(How = How.XPath, Using = "//a[@class='menu-categories__link' and text()='Ноутбуки и компьютеры']")]
        private IWebElement notebooksAndComputersMenuLinkInGeneralMenu;

        #endregion

        #region Methods

        internal NotebooksAndComputersPage GoToNotebooksAndComputersPage()
        {
            Actions.DoubleClick(notebooksAndComputersMenuLinkInGeneralMenu).Build().Perform();
            return new NotebooksAndComputersPage();
        }

        #endregion
    }
}
