using OpenQA.Selenium;
using TechTalk.SpecFlow;
using Utilities;

namespace ELITEADemo.Hooks
{
    [Binding]
    public class LoginHooks
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly DriverHelper _driverHelper;

        public LoginHooks(ScenarioContext scenarioContext, DriverHelper driverHelper)
        {
            _scenarioContext = scenarioContext;
            _driverHelper = driverHelper;
        }

        [BeforeScenario("Login")]
        public void BeforeScenario()
        {
            _driverHelper.InitializeDriver();
        }

        [AfterScenario("Login")]
        public void AfterScenario()
        {
            _driverHelper.QuitDriver();
        }
    }
}