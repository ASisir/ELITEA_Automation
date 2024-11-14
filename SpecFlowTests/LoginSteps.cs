using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

[Binding]
public class LoginSteps
{
    IWebDriver driver = new ChromeDriver();

    [Given("the user is on the Sauce Demo login page")]
    public void GivenTheUserIsOnTheSauceDemoLoginPage()
    {
        driver.Navigate().GoToUrl("https://www.saucedemo.com");
    }

    [When("the user enters '(.*)' as username and '(.*)' as password")]
    public void WhenTheUserEntersAsUsernameAndAsPassword(string username, string password)
    {
        driver.FindElement(By.Id("user-name")).SendKeys(username);
        driver.FindElement(By.Id("password")).SendKeys(password);
    }

    [When("the user clicks on the login button")]
    public void WhenTheUserClicksOnTheLoginButton()
    {
        driver.FindElement(By.Id("login-button")).Click();
    }

    [Then("the user should be redirected to the inventory page")]
    public void ThenTheUserShouldBeRedirectedToTheInventoryPage()
    {
        Assert.AreEqual("https://www.saucedemo.com/inventory.html", driver.Url);
    }

    [Then("the user should see an error message")]
    public void ThenTheUserShouldSeeAnErrorMessage()
    {
        Assert.IsTrue(driver.FindElement(By.ClassName("error-message-container")).Displayed);
    }
}