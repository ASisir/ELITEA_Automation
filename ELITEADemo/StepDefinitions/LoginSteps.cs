using TechTalk.SpecFlow;

[Binding]
public class LoginSteps
{
    [Given("I am on the Sauce Demo login page")]
    public void GivenIAmOnTheSauceDemoLoginPage()
    {
        // Implementation here
    }

    [When("I enter '(.*)' as username and '(.*)' as password")]
    public void WhenIEnterAsUsernameAndAsPassword(string username, string password)
    {
        // Implementation here
    }

    [When("I click on the login button")]
    public void WhenIClickOnTheLoginButton()
    {
        // Implementation here
    }

    [Then("I should be redirected to the inventory page")]
    public void ThenIShouldBeRedirectedToTheInventoryPage()
    {
        // Implementation here
    }

    [Then("I should see an error message")]
    public void ThenIShouldSeeAnErrorMessage()
    {
        // Implementation here
    }
}