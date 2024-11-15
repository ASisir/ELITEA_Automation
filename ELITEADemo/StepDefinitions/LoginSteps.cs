using System;
using TechTalk.SpecFlow;

namespace ELITEADemo.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        [Given("User is on Login Page of Sauce Demo")]
        public void GivenUserIsOnLoginPage()
        {
            // Implementation to navigate to login page
        }

        [When("User enters valid Username and Password")]
        [When("User enters invalid Username and Password")]
        [When("User leaves Username and Password fields empty")]
        public void WhenUserEntersCredentials(string username, string password)
        {
            // Implementation to enter credentials
        }

        [When("User clicks on Logout button")]
        public void WhenUserClicksLogout()
        {
            // Implementation to click logout
        }

        [When("User checks the Remember Me checkbox")]
        public void WhenUserChecksRememberMe()
        {
            // Implementation to check the checkbox
        }

        [Then("User should be redirected to the Home Page")]
        [Then("User should see an error message")]
        public void ThenUserShouldSeeResult()
        {
            // Implementation to verify the result
        }
    }
}