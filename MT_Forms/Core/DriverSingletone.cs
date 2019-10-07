using NLog;
using OpenQA.Selenium;

namespace Core
{
    class DriverSingletone
    {
        private static IWebDriver _driver;
        private static Logger _log = LogManager.GetCurrentClassLogger();

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
