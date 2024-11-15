using OpenQA.Selenium;
using TechTalk.SpecFlow;
using ELITEADemo.Utilities;

namespace ELITEADemo.Hooks
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
        public void Initialize()
        {
            _driver = DriverHelper.InitializeDriver();
            _scenarioContext["WebDriver"] = _driver;
        }

        [AfterScenario]
        public void CleanUp()
        {
            _driver.Quit();
        }
    }
}