using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Utilities
{
    public class UtilHelper
    {
        public IWebDriver driver;

        public UtilHelper()
        {
            driver = new ChromeDriver();
        }

        public void NavigateToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
    }
}