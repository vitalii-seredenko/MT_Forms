using OpenQA.Selenium;
using POMExample.Core;
using POMExample.TestData;
using SeleniumExtras.PageObjects;

namespace POMExample.PageObjects
{
    internal class NotebooksAndComputersPage : SiteHeader
    {
        private readonly string _pageUrl = PageUrls.NotebooksAndComputersPageUrl;

        internal NotebooksAndComputersPage()
        {
            PageFactory.InitElements(Driver, this);
            AssertPage(_pageUrl);
        }

        #region WebElements

        [FindsBy(How = How.XPath, Using = "//p//a[@href='https://rozetka.com.ua/notebooks/c80004/']")]
        private IWebElement notebooksLink;

        #endregion

        #region Methods

        internal NotebooksPage GoToNotebooksPage()
        {
            notebooksLink.WaitElement().Click();
            return new NotebooksPage();
        }

        #endregion
    }
}
