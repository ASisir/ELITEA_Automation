using TechTalk.SpecFlow;

[Binding]
public class LoginSteps
{
    [Given("User is on the login page of Sauce Demo")]
    public void GivenUserIsOnTheLoginPage()
    {
        // Code to navigate to login page
    }

    [When("User enters valid username and password")]
    public void WhenUserEntersValidCredentials()
    {
        // Code to enter credentials
    }

    [When("User enters invalid username and password")]
    public void WhenUserEntersInvalidCredentials()
    {
        // Code to enter credentials
    }

    [When("User leaves the username and password field empty")]
    public void WhenUserLeavesCredentialsEmpty()
    {
        // Code to leave fields empty
    }

    [When("User clicks on the login button")]
    public void WhenUserClicksLoginButton()
    {
        // Code to click login button
    }

    [Then("User should be redirected to the home page")]
    public void ThenUserShouldBeRedirectedToHomePage()
    {
        // Code to verify redirection
    }

    [Then("User should see an error message")]
    public void ThenUserShouldSeeAnErrorMessage()
    {
        // Code to verify error message
    }
}