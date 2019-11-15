using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using POMExample.TestData;

namespace POMExample.PageObjects
{
    internal class NotebooksPage : SiteHeader
    {
        private readonly string _pageUrl = PageUrls.NotebooksPageUrl;

        internal NotebooksPage()
        {
            PageFactory.InitElements(Driver, this);
            AssertPage(_pageUrl);
        }

        #region WebElements

        [FindsBy(How = How.XPath, Using = "//div[//p[text()='Популярные модели']]//div[@class='scroller']//div[@class='slider-i-td'][1]//a[@class='g-title-link']")]
        private IWebElement firstPopularNotebookLink;

        #endregion

        #region Methods

        internal void ClickOnFirstPopularNotebook()
        {
            ExplicitWait.Until(condition => firstPopularNotebookLink.Displayed);
            firstPopularNotebookLink.Click();
        }

        #endregion
    }
}
