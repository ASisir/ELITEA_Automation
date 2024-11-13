[Binding]
public class LoginStepDefinitions
{
    private IWebDriver driver;
    private LoginPage loginPage;

    [Given(@"User is at the Login Page")]
    public void GivenUserIsAtTheLoginPage()
    {
        driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://www.saucedemo.com");
        loginPage = new LoginPage(driver);
    }

    [When(@"User enters Username as '(.*)' and Password as '(.*)'")]
    public void WhenUserEntersUsernameAndPassword(string username, string password)
    {
        loginPage.EnterUsername(username);
        loginPage.EnterPassword(password);
    }

    [When(@"Clicks on the Login button")]
    public void WhenClicksOnTheLoginButton()
    {
        loginPage.ClickLoginButton();
    }

    [Then(@"User should be redirected to the home page")]
    public void ThenUserShouldBeRedirectedToTheHomePage()
    {
        Assert.IsTrue(driver.Url.Contains("inventory.html"));
        driver.Quit();
    }
}