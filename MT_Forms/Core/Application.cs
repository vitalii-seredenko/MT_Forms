using OpenQA.Selenium;

namespace MT_Forms.Core
{
    internal class Application
    {
        private readonly IWebDriver _driver;
        private readonly Logger _logger;

        internal Application()
        {
            _logger = new Logger();
            _driver = DriverSingleton.Driver;
        }


        internal void DisposeDriver()
        {
            _driver?.Dispose();
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
