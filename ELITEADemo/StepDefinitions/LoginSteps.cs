using TechTalk.SpecFlow;

[Binding]
public class LoginSteps
{
    [Given("I am on the Sauce Demo login page")]
    public void GivenIAmOnTheSauceDemoLoginPage()
    {
        // Implementation here
    }

    [When("I enter the username as '(.*)' and password as '(.*)'")]
    public void WhenIEnterTheUsernameAndPassword(string username, string password)
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

    [When("I click on the menu button")]
    public void WhenIClickOnTheMenuButton()
    {
        // Implementation here
    }

    [When("I click on the logout link")]
    public void WhenIClickOnTheLogoutLink()
    {
        // Implementation here
    }

    [When("I enter the password as '(.*)'")]
    public void WhenIEnterThePasswordAs(string password)
    {
        // Implementation here
    }

    [Then("I should be able to toggle the visibility of the password")]
    public void ThenIShouldBeAbleToToggleTheVisibilityOfThePassword()
    {
        // Implementation here
    }
}