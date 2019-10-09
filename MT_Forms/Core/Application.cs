using NLog;
using OpenQA.Selenium;

namespace MT_Forms.Core
{
    internal class Application
    {
        private readonly IWebDriver _driver;

        internal Application()
        {
            _driver = DriverSingleton.Driver;
        }

        internal void DisposeDriver()
        {
            _driver.Dispose();
        }

        internal void MaximizeBrowserWindow()
        {
            _driver.Manage().Window.Maximize();
        }

        internal void NavigateToUrl(string url)
        {
            _driver.Navigate().GoToUrl(url);
            LogManager.GetCurrentClassLogger().Info($"User navigates to '{url}'");
        }
    }
}
