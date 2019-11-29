using OpenQA.Selenium;
using POMExample.Core;
using POMExample.PageObjects;
using POMExample.TestData;
using System;

namespace POMExample.CommonMethods
{
    internal class Navigation
    {
        private readonly IWebDriver _driver = DriverSingleton.Driver;

        internal object NavigateToPage(string pageName)
        {
            switch (pageName)
            {
                case "Home page":
                    _driver.Navigate().GoToUrl(PageUrls.HomePageUrl);
                    return new HomePage();
                case "Notebooks and computer page":
                    _driver.Navigate().GoToUrl(PageUrls.NotebooksAndComputersPageUrl);
                    return new NotebooksAndComputersPage();
                case "Notebook Page":
                    _driver.Navigate().GoToUrl(PageUrls.NotebooksPageUrl);
                    return new NotebooksPage();
                default:
                    throw new ArgumentException($"{pageName} does not exist");
            }
        }
    }
}
