using System;
using System.Diagnostics;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;

namespace POMExample.Core
{
    static class WebElementExtension
    {
        public static IWebElement WaitElement(this IWebElement element, int seconds = 5)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            while (timer.Elapsed < TimeSpan.FromSeconds(seconds))
            {
                try
                {
                    if(element.Displayed)
                        return element;
                }
                catch (WebDriverException)
                {
                    Thread.Sleep(1000);
                }
            }
            timer.Stop();
            return null;
        }
    }
}
