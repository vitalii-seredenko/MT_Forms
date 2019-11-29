using OpenQA.Selenium;
using System;
using System.Diagnostics;
using System.Threading;

namespace POMExample.Core
{
    static class WebElementExtension
    {
        public static IWebElement WaitElement(this IWebElement element, int seconds = 5)
        {
            var timer = new Stopwatch();
            timer.Start();
            while (timer.Elapsed < TimeSpan.FromSeconds(seconds))
            {
                try
                {
                    if (element.Displayed)
                        return element;
                }
                catch (WebDriverException)
                {
                    Thread.Sleep(500);
                }
            }
            timer.Stop();
            return null;
        }
    }
}
