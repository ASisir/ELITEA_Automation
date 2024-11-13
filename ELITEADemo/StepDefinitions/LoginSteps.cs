using TechTalk.SpecFlow;

namespace ELITEADemo.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        [Given("I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            // Navigate to the login page
        }

        [When("I enter username as '(.*)' and password as '(.*)'")]
        public void WhenIEnterUsernameAsAndPasswordAs(string username, string password)
        {
            // Enter username and password
        }

        [Then("I should be redirected to the inventory page")]
        public void ThenIShouldBeRedirectedToTheInventoryPage()
        {
            // Verify that the user is redirected to the inventory page
        }

        [Then("I should see an error message")]
        public void ThenIShouldSeeAnErrorMessage()
        {
            // Verify that an error message is displayed
        }
    }
}