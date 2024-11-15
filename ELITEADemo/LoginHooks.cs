using TechTalk.SpecFlow;
using ELITEADemo.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ELITEADemo
{
    [Binding]
    public class LoginHooks
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver _driver;

        public LoginHooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _scenarioContext["driver"] = _driver;
        }

        [AfterScenario]
        public void TearDown()
        {
            if (_driver != null)
            {
                _driver.Quit();
            }
        }
    }
}