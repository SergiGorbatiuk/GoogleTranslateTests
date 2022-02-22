using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleTranslateTests
{
    public static class Expectation
    {
        public static void LocateUrl(IWebDriver webDriver, string url)
        {
            try
            {
                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.UrlContains(url));
            }
            catch (WebDriverTimeoutException)
            {
                throw new NotFoundException($"Unable to find location {url}");
            }
        }
        public static void WaitForElementVisible(IWebDriver webDriver, By locator, int seconds = 5)
        {
            new WebDriverWait(webDriver, TimeSpan.FromSeconds(seconds)).Until(ExpectedConditions.ElementIsVisible(locator));
        }

        public static void WaitForElementClickable(IWebDriver webDriver, By locator, int seconds = 5)
        {
            new WebDriverWait(webDriver, TimeSpan.FromSeconds(seconds)).Until(ExpectedConditions.ElementIsVisible(locator));
            new WebDriverWait(webDriver, TimeSpan.FromSeconds(seconds)).Until(ExpectedConditions.ElementToBeClickable(locator));
        }
    }
}
