using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

[Binding]
public class LoginStepDefinitions
{
    private IWebDriver driver;

    [Given("I am on the Sauce Demo login page")]
    public void GivenIAmOnTheSauceDemoLoginPage()
    {
        driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://www.saucedemo.com");
    }

    [When("I enter username as '(.*)' and password as '(.*)'")]
    public void WhenIEnterUsernameAndPassword(string username, string password)
    {
        driver.FindElement(By.Id("user-name")).SendKeys(username);
        driver.FindElement(By.Id("password")).SendKeys(password);
    }

    [When("I click on the login button")]
    public void WhenIClickOnTheLoginButton()
    {
        driver.FindElement(By.Id("login-button")).Click();
    }

    [Then("I should be redirected to the inventory page")]
    public void ThenIShouldBeRedirectedToTheInventoryPage()
    {
        Assert.AreEqual("https://www.saucedemo.com/inventory.html", driver.Url);
        driver.Quit();
    }

    [Then("I should see an error message")]
    public void ThenIShouldSeeAnErrorMessage()
    {
        Assert.IsTrue(driver.FindElement(By.ClassName("error-message-container")).Displayed);
        driver.Quit();
    }
}