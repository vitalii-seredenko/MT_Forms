using OpenQA.Selenium;

namespace Core
{
    class DriverSingletone
    {
        public static IWebDriver driver;

        public static IWebDriver Driver
        {
            get
            {
                if (driver == null)
                {
                    driver = new DriverFactory().GetDriver("chrome");
                }
                return driver;
            }
        }
    }
}
