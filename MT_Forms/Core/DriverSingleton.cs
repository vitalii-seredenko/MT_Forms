using NLog;
using OpenQA.Selenium;

namespace MT_Forms.Core
{
    class DriverSingleton
    {
        private static Logger _log = LogManager.GetCurrentClassLogger();
        private static IWebDriver _driver;

        public static IWebDriver Driver
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

        public static void DisposeDriver()
        {
            _driver.Dispose();
            _log.Info("<-----------Application finished----------->\n");
        }
    }
}
