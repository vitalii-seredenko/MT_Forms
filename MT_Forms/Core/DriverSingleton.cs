using NLog;
using OpenQA.Selenium;

namespace MT_Forms.Core
{
    internal class DriverSingleton
    {
        private static Logger _log = LogManager.GetCurrentClassLogger();
        private static IWebDriver _driver;

        internal static IWebDriver Driver
        {
            get
            {
                if (_driver == null)
                {
                    _driver = new DriverFactory().GetDriver("chrome");
                }
                return _driver;
            }
        }

        internal static void DisposeDriver()
        {
            _driver.Dispose();
        }
    }
}
