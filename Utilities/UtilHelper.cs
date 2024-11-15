using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ELITEADemo.Utilities
{
    public static class UtilHelper
    {
        public static IWebDriver InitializeWebDriver()
        {
            return new ChromeDriver();
        }
    }
}