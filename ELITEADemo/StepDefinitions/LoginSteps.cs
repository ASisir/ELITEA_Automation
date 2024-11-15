using System;
using TechTalk.SpecFlow;

namespace ELITEADemo.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        [Given("User is on the Sauce Demo Login Page")]
        public void GivenUserIsOnTheSauceDemoLoginPage()
        {
            // Code to navigate to login page
        }

        [When("User enters valid username and password")]
        public void WhenUserEntersValidUsernameAndPassword()
        {
            // Code to enter username and password
        }

        [When("User enters invalid username and password")]
        public void WhenUserEntersInvalidUsernameAndPassword()
        {
            // Code to enter invalid credentials
        }

        [When("User leaves the username and password fields empty")]
        public void WhenUserLeavesTheUsernameAndPasswordFieldsEmpty()
        {
            // Code to leave fields empty
        }

        [When("User clicks on Login button")]
        public void WhenUserClicksOnLoginButton()
        {
            // Code to click login button
        }

        [Then("User should be redirected to the Home Page")]
        public void ThenUserShouldBeRedirectedToTheHomePage()
        {
            // Code to verify redirection
        }

        [Then("User should see an error message")]
        public void ThenUserShouldSeeAnErrorMessage()
        {
            // Code to verify error message
        }
    }
}