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

    [When(@"I enter "(.*)" as username and "(.*)" as password")]
    public void WhenIEnterAsUsernameAndAsPassword(string username, string password)
    {
        loginPage.EnterUsername(username);
        loginPage.EnterPassword(password);
    }

    [When(@"I click on the login button")]
    public void WhenIClickOnTheLoginButton()
    {
        loginPage.ClickLoginButton();
    }

    [Then(@"I should be redirected to the inventory page")]
    public void ThenIShouldBeRedirectedToTheInventoryPage()
    {
        Assert.AreEqual("https://www.saucedemo.com/inventory.html", driver.Url);
    }
}