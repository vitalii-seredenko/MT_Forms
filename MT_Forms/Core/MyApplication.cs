using MT_Forms.Core.Driver;
using OpenQA.Selenium;

namespace MT_Forms.Core
{
    internal class MyApplication
    {
        private readonly IWebDriver _driver = DriverSingleton.Driver;
        private readonly Logger.Logger _logger = new Logger.Logger();

        internal void DisposeDriver()
        {
            _driver.Dispose();
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
