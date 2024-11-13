using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ELITEADemo.PageObjects;

[Binding]
public class LoginStepDefinitions
{
    private IWebDriver driver;
    private LoginPage loginPage;

    [Given("I am on the login page")]
    public void GivenIAmOnTheLoginPage()
    {
        driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://www.saucedemo.com");
        loginPage = new LoginPage(driver);
    }

    [When("I enter username as '(.*)' and password as '(.*)'")]
    public void WhenIEnterUsernameAndPassword(string username, string password)
    {
        loginPage.EnterUsername(username);
        loginPage.EnterPassword(password);
    }

    [When("I click on login button")]
    public void WhenIClickOnLoginButton()
    {
        loginPage.ClickLoginButton();
    }

    [Then("I should be redirected to the products page")]
    public void ThenIShouldBeRedirectedToTheProductsPage()
    {
        // Assertion code here
    }

    [Then("I should see an error message")]
    public void ThenIShouldSeeAnErrorMessage()
    {
        // Assertion code here
    }
}