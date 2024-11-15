using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Utilities
{
    public static class UtilHelper
    {
        public static IWebDriver Driver { get; private set; }

        static UtilHelper()
        {
            Driver = new ChromeDriver();
        }
    }
}