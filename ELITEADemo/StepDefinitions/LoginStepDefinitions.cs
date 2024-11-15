using TechTalk.SpecFlow;
using ELITEADemo.PageObjects;
using ELITEADemo.Utilities;

[Binding]
public class LoginStepDefinitions
{
    private readonly ScenarioContext _scenarioContext;
    private readonly LoginPage _loginPage;
    private readonly DriverHelper _driverHelper;

    public LoginStepDefinitions(ScenarioContext scenarioContext, LoginPage loginPage, DriverHelper driverHelper)
    {
        _scenarioContext = scenarioContext;
        _loginPage = loginPage;
        _driverHelper = driverHelper;
    }

    [Given("User is on the login page")]
    public void GivenUserIsOnTheLoginPage()
    {
        _driverHelper.GoToUrl("https://www.saucedemo.com");
    }

    [When("User enters '(.*)' as username and '(.*)' as password")]
    public void WhenUserEntersAsUsernameAndAsPassword(string username, string password)
    {
        _loginPage.EnterUsername(username);
        _loginPage.EnterPassword(password);
    }

    [When("User clicks on the login button")]
    public void WhenUserClicksOnTheLoginButton()
    {
        _loginPage.ClickLoginButton();
    }

    [Then("User should be redirected to the products page")]
    public void ThenUserShouldBeRedirectedToTheProductsPage()
    {
        // Assert that the user is redirected to the products page
    }

    [Then("User should see an error message")]
    public void ThenUserShouldSeeAnErrorMessage()
    {
        // Assert that an error message is displayed
    }
}