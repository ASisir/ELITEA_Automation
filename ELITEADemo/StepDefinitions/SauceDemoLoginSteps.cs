using TechTalk.SpecFlow;
using PageObjects;

[Binding]
public class SauceDemoLoginSteps
{
    private readonly LoginPage loginPage;

    public SauceDemoLoginSteps()
    {
        loginPage = new LoginPage();
    }

    [Given("User is on Login Page")]
    public void GivenUserIsOnLoginPage()
    {
        loginPage.GoTo();
    }

    [When("User enters valid username and password")]
    public void WhenUserEntersValidUsernameAndPassword()
    {
        loginPage.Login("standard_user", "secret_sauce");
    }

    [Then("User should be able to login successfully")]
    public void ThenUserShouldBeAbleToLoginSuccessfully()
    {
        Assert.IsTrue(loginPage.IsLoggedIn());
    }
}