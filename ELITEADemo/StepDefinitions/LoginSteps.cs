[Binding]
public class LoginSteps
{
    private IWebDriver driver;
    private LoginPage loginPage;

    public LoginSteps()
    {
        driver = new ChromeDriver();
        loginPage = new LoginPage(driver);
    }

    [Given(@"I am on the Sauce demo login page")]
    public void GivenIAmOnTheSauceDemoLoginPage()
    {
        driver.Navigate().GoToUrl("https://www.saucedemo.com");
    }

    [When(@"I enter username as '(.*)' and password as '(.*)'")]
    public void WhenIEnterUsernameAsAndPasswordAs(string username, string password)
    {
        loginPage.EnterUsername(username);
        loginPage.EnterPassword(password);
    }

    [When(@"I click on the login button")]
    public void WhenIClickOnTheLoginButton()
    {
        loginPage.ClickLogin();
    }

    [Then(@"I should be redirected to the inventory page")]
    public void ThenIShouldBeRedirectedToTheInventoryPage()
    {
        Assert.AreEqual("https://www.saucedemo.com/inventory.html", driver.Url);
    }

    [Then(@"I should see an error message")]
    public void ThenIShouldSeeAnErrorMessage()
    {
        Assert.IsTrue(loginPage.IsErrorMessageDisplayed());
    }
}