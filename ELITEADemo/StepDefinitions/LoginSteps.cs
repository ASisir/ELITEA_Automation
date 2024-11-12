using TechTalk.SpecFlow;

namespace ELITEADemo.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        [Given("User is on the Sauce Demo Login Page")]
        public void GivenUserIsOnTheSauceDemoLoginPage()
        {
            // Implementation here...
        }

        [When("User enters '(.*)' as username and '(.*)' as password")]
        public void WhenUserEntersAsUsernameAndAsPassword(string username, string password)
        {
            // Implementation here...
        }

        [When("User clicks on the Login button")]
        public void WhenUserClicksOnTheLoginButton()
        {
            // Implementation here...
        }

        [Then("User should be redirected to the Products page")]
        public void ThenUserShouldBeRedirectedToTheProductsPage()
        {
            // Implementation here...
        }

        [Then("User should see an error message")]
        public void ThenUserShouldSeeAnErrorMessage()
        {
            // Implementation here...
        }
    }
}