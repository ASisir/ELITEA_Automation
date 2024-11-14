using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ELITEADemo.Utilities
{
    public class WebDriverHelper
    {
        public static IWebDriver driver;

        public static IWebDriver InitializeDriver()
        {
            driver = new ChromeDriver();
            return driver;
        }
    }
}