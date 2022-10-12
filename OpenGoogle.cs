using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace Test
{
    public class Tests : BaseTest
    {
        [Test]
        public void LoadGoogle()
        {
            _webDriver?.Navigate().GoToUrl("https://www.google.com");
            Assert.True(_webDriver?.Title.Contains("Google"));
        }

        [Test]
        public void LoadSearchBox()
        {
            _webDriver?.Navigate().GoToUrl("https://www.google.com/ncr");

            By accept_button = By.XPath("//button/div[contains(., 'Accept all')]");
            IWebElement? accept_button_elem = _wait?.Until(ExpectedConditions.ElementToBeClickable(accept_button));
            accept_button_elem?.Click();

            By search_box = By.XPath("//input[@title='Search']");
            _wait?.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(search_box));
        }
    }
}
