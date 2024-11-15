using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Utilities
{
    public static class WebDriverUtility
    {
        public static IWebDriver Driver { get; set; }

        public static void InitializeDriver()
        {
            // Implementation to initialize WebDriver
        }

        public static void NavigateTo(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        public static void WaitForElementVisible(By by, int timeoutInSeconds)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(timeoutInSeconds));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
        }
    }
}