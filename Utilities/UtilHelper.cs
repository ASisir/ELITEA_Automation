using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Utilities
{
    public class UtilHelper
    {
        private readonly IWebDriver _driver;

        public UtilHelper(IWebDriver driver)
        {
            _driver = driver;
        }

        public void GoToUrl(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public bool IsUrl(string url)
        {
            return _driver.Url == url;
        }

        // Add other utility methods here
    }
}

