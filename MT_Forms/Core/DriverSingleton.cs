﻿using OpenQA.Selenium;

namespace MT_Forms.Core
{
    internal enum Drivers
    {
        Chrome = 1,
        FireFox
    }

    internal class DriverSingleton
    {
        private static IWebDriver _driver;

        internal static IWebDriver Driver
        {
            get
            {
                if (_driver == null)
                    _driver = new DriverFactory().GetDriver(Drivers.Chrome);
                return _driver;
            }
        }

        internal static void DisposeDriver()
        {
            _driver.Dispose();
        }
    }
}
