using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
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
        private IWebElement notebooksAndComputersMenuLink;

        #endregion

        #region Methods

        internal NotebooksAndComputersPage GoToNotebooksAndComputersPage()
        {
            ExplicitWait.Until(condition => notebooksAndComputersMenuLink.Displayed);
            notebooksAndComputersMenuLink.Click();
            return new NotebooksAndComputersPage();
        }

        #endregion
    }
}
