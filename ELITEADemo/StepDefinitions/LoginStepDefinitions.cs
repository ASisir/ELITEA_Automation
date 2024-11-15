using TechTalk.SpecFlow;
using PageObjects;
using Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow.NUnit;
using NUnit.Framework;

[Binding]
public class LoginStepDefinitions
{
    private readonly IWebDriver _driver;
    private readonly LoginPage _loginPage;
    private readonly UtilHelper _utilHelper;

    public LoginStepDefinitions()
    {
        _driver = new ChromeDriver();
        _loginPage = new LoginPage(_driver);
        _utilHelper = new UtilHelper(_driver);
    }

    [Given("User is on the login page")]
    public void GivenUserIsOnTheLoginPage()
    {
        _utilHelper.GoToUrl("https://www.saucedemo.com");
    }

    [When("User enters valid username and password")]
    public void WhenUserEntersValidUsernameAndPassword()
    {
        _loginPage.EnterUsername("standard_user");
        _loginPage.EnterPassword("secret_sauce");
    }

    [When("User clicks on the login button")]
    public void WhenUserClicksOnTheLoginButton()
    {
        _loginPage.ClickLogin();
    }

    [Then("User should be redirected to the home page")]
    public void ThenUserShouldBeRedirectedToTheHomePage()
    {
        Assert.IsTrue(_utilHelper.IsUrl("https://www.saucedemo.com/inventory.html"));
    }

    // Add the remaining step definitions here

[When("I enter invalid username and password")]
public void WhenIEnterInvalidUsernameAndPassword()
{
    _loginPage.EnterUsername("invalid_user");
    _loginPage.EnterPassword("wrong_sauce");
    _loginPage.ClickLogin();
}

[Then("I should see an error message")]
public void ThenIShouldSeeAnErrorMessage()
{
    Assert.IsTrue(_loginPage.ErrorMessageDisplayed());
}
}