using TechTalk.SpecFlow;

namespace ELITEADemo.StepDefinitions
{
    [Binding]
    public class SauceDemoLoginSteps
    {
        [Given("User is on Sauce Demo Login Page")]
        public void GivenUserIsOnSauceDemoLoginPage()
        {
            // Implementation here
        }

        [When("User enters valid username and password")]
        public void WhenUserEntersValidUsernameAndPassword()
        {
            // Implementation here
        }

        [When("User clicks on Login button")]
        public void WhenUserClicksOnLoginButton()
        {
            // Implementation here
        }

        [Then("User should be redirected to the home page")]
        public void ThenUserShouldBeRedirectedToTheHomePage()
        {
            // Implementation here
        }

        [When("User enters invalid username and password")]
        public void WhenUserEntersInvalidUsernameAndPassword()
        {
            // Implementation here
        }

        [Then("User should see an error message")]
        public void ThenUserShouldSeeAnErrorMessage()
        {
            // Implementation here
        }

        [When("User leaves the username and password fields empty")]
        public void WhenUserLeavesTheUsernameAndPasswordFieldsEmpty()
        {
            // Implementation here
        }

        [Given("User is logged in Sauce Demo")]
        public void GivenUserIsLoggedInSauceDemo()
        {
            // Implementation here
        }

        [When("User clicks on Logout button")]
        public void WhenUserClicksOnLogoutButton()
        {
            // Implementation here
        }

        [Then("User should be redirected to the login page")]
        public void ThenUserShouldBeRedirectedToTheLoginPage()
        {
            // Implementation here
        }

        [When("User clicks on Remember Me checkbox")]
        public void WhenUserClicksOnRememberMeCheckbox()
        {
            // Implementation here
        }

        [Then("User's credentials should be remembered for future logins")]
        public void ThenUserSCredentialsShouldBeRememberedForFutureLogins()
        {
            // Implementation here
        }
    }
}