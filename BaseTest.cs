using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.UI;
using System;

namespace Test
{
    [TestFixture]
    public class BaseTest
    {
        public IWebDriver? _webDriver;
        public WebDriverWait? _wait;

        [SetUp]
        public void SetUp()
        {
            var opts = new ChromeOptions();
            opts.AddArgument("--headless");
            new DriverManager().SetUpDriver(new ChromeConfig());
            _webDriver = new ChromeDriver(opts);
            _wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(15.00));
        }

        [TearDown]
        public void TearDown()
        {
            _webDriver?.Quit();
        }
    }
}
