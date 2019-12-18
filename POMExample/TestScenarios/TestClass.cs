using NUnit.Framework;
using OpenQA.Selenium;
using POMExample.CommonMethods;
using POMExample.Core;
using POMExample.PageObjects;

namespace POMExample.TestScenarios
{
    [TestFixture]
    internal class TestClass
    {
        private IWebDriver _driver;

        [SetUp]
        public void SetUp()
        {
            _driver = DriverSingleton.Driver;
            _driver.Manage().Window.Maximize();
        }

        [Test]
        [Category("Smoke")]
        public void SearchFirstPopularNotebook()
        {
            var navigation = new Navigation();
            ((HomePage)navigation.NavigateToPage("Home page")).GoToNotebooksAndComputersPage().GoToNotebooksPage().ClickOnFirstPopularNotebook();
            //Some assertion here
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Dispose();
        }
    }
}
