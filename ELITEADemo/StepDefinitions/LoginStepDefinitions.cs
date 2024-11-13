using TechTalk.SpecFlow;
using ELITEADemo.PageObjects;
using OpenQA.Selenium;

[Binding]
public class LoginStepDefinitions
{
    private IWebDriver driver;
    private LoginPage loginPage;

    public LoginStepDefinitions(IWebDriver driver)
    {
        this.driver = driver;
        loginPage = new LoginPage(driver);
    }

    [Given("I am on the Sauce Demo login page")]
    public void GivenIAmOnTheSauceDemoLoginPage()
    {
        driver.Navigate().GoToUrl("https://www.saucedemo.com");
    }

    [When("I enter the username as "(.*)" and password as "(.*)")]
    public void WhenIEnterTheUsernameAndPassword(string username, string password)
    {
        loginPage.EnterUsernameAndPassword(username, password);
    }

    [When("I click on the login button")]
    public void WhenIClickOnTheLoginButton()
    {
        loginPage.ClickLoginButton();
    }

    [Then("I should be redirected to the inventory page")]
    public void ThenIShouldBeRedirectedToTheInventoryPage()
    {
        // Assert that the user is redirected to the inventory page
    }

    [Then("I should see an error message")]
    public void ThenIShouldSeeAnErrorMessage()
    {
        // Assert that an error message is displayed
    }
}