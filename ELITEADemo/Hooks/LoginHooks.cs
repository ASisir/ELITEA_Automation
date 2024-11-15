using System;
using TechTalk.SpecFlow;

namespace ELITEADemo.Hooks
{
    [Binding]
    public class LoginHooks
    {
        [BeforeScenario("Login")]
        public void BeforeLoginScenario()
        {
            // Code to setup test environment before login scenario
        }

        [AfterScenario("Login")]
        public void AfterLoginScenario()
        {
            // Code to clean up after login scenario
        }
    }
}