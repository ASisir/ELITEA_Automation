using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SauceDemo.Utilities
{
    public class WebDriverHelper
    {
        public IWebDriver InitializeDriver()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            return driver;
        }
    }
}