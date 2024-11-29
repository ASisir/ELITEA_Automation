using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SauceDemo
{
    [Binding]
    public class LoginHooks
    {
        private IWebDriver _driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            _driver = new WebDriverHelper().InitializeDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driver.Quit();
        }
    }
}