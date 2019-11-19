using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Threading;
using OpenQA.Selenium;

namespace MT_Forms.Extensions
{
    static class WebElementExtension
    {
        internal static IWebElement WaitElement(this IWebElement element, int seconds = 3)
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

        internal static void WaitElementAndClick(this IWebElement element, int seconds = 3)
        {
            var timer = new Stopwatch();
            timer.Start();
            while (timer.Elapsed < TimeSpan.FromSeconds(seconds))
            {
                try
                {
                    if (element.Displayed) 
                        element.Click();
                }
                catch (WebDriverException)
                {
                    Thread.Sleep(500);
                }
            }
            timer.Stop();
        }

        internal static void ClickOnElementWithRandomInterval(this IWebElement element)
        {
            var timer = new Stopwatch();
            timer.Start();
            while (timer.Elapsed > TimeSpan.FromSeconds(new Random().Next(1500,3000)))
            {
                element.Click();
            }
            timer.Stop();
        }

        internal static bool IsElementPresent(this IWebElement element)
        {
            try
            {
                return element.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        internal static string ReturnElementTextIfElementPresent(this IWebElement element)
        {
            try
            {
                return element.Displayed ? element.Text : "0";
            }
            catch (NoSuchElementException)
            {
                return "0";
            }
        }

        internal static string CutLettersFromTextBox(this IWebElement element)
        {
            var levelMatch = new Regex("\\d+").Match(element.ReturnElementTextIfElementPresent());
            return levelMatch.Value;
        }
    }
}
