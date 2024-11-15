using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Utilities
{
    public static class WebdriverUtility
    {
        public static IWebDriver driver;

        public static void InitializeDriver()
        {
            // Code to initialize WebDriver
        }

        public static void NavigateToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public static void EnterText(IWebElement element, string text)
        {
            element.SendKeys(text);
        }

        public static void ClickElement(IWebElement element)
        {
            element.Click();
        }

        public static void WaitForElementVisible(IWebElement element, int timeoutInSeconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(element));
        }
    }
}