using MT_Forms.Core.Driver;
using OpenQA.Selenium;

namespace MT_Forms.Core
{
    internal class MyApplication
    {
        private readonly IWebDriver _driver;
        private readonly Logger.Logger _logger;

        internal MyApplication()
        {
            _logger = new Logger.Logger();
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
            try
            {
                _driver.Navigate().GoToUrl(url);
                _logger.Info($"User navigates to '{url}'");
            }
            catch (WebDriverException exception)
            {
                _logger.Fatal(exception.Message);
            }
        }
    }
}
