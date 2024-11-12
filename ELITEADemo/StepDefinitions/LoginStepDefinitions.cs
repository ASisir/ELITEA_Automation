using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace ELITEADemo.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private IWebDriver _driver;

        public LoginStepDefinitions(IWebDriver driver)
        {
            _driver = driver;
        }

        [Given("I am on the Sauce Demo login page")]
        public void GivenIAmOnTheSauceDemoLoginPage()
        {
            _driver.Navigate().GoToUrl("https://www.saucedemo.com");
        }

        [When("I enter '(.*)' as username and '(.*)' as password")]
        public void WhenIEnterAsUsernameAndAsPassword(string username, string password)
        {
            _driver.FindElement(By.Id("user-name")).SendKeys(username);
            _driver.FindElement(By.Id("password")).SendKeys(password);
        }

        [When("I click on the login button")]
        public void WhenIClickOnTheLoginButton()
        {
            _driver.FindElement(By.Id("login-button")).Click();
        }

        [Then("I should be redirected to the products page")]
        public void ThenIShouldBeRedirectedToTheProductsPage()
        {
            Assert.IsTrue(_driver.Url.Contains("inventory.html"));
        }

        [Then("I should see an error message")]
        public void ThenIShouldSeeAnErrorMessage()
        {
            Assert.IsTrue(_driver.FindElement(By.ClassName("error-message-container")).Displayed);
        }
    }
}