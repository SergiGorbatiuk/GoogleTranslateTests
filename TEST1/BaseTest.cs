using GoogleTranslateTests.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleTranslateTests
{
    public class BaseTest
    {
        protected IWebDriver _webDriver;

        [TearDown]
        protected void AfterEach()
        {
            _webDriver.Quit();
        }
        [SetUp]
        protected void BeforeEach()
        {
            _webDriver = new ChromeDriver();
            _webDriver.Manage().Cookies.DeleteAllCookies();
            _webDriver.Manage().Window.Maximize();
            _webDriver.Navigate().GoToUrl(TestSettings.hostPrefixEnToUk);
        }
    }
}
