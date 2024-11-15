using OpenQA.Selenium;
using PageObjects;
using Utilities;

namespace ELITEADemo.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private readonly LoginPage _loginPage;
        private readonly IWebDriver _driver;

        public LoginStepDefinitions(DriverHelper driverHelper)
        {
            _driver = driverHelper.Driver;
            _loginPage = new LoginPage(_driver);
        }

        [Given("I navigate to the login page")]
        public void GivenINavigateToTheLoginPage()
        {
            _driver.Navigate().GoToUrl("https://www.saucedemo.com");
        }

        [When("I enter username \"(.*)\" and password \"(.*)\"")]
        public void WhenIEnterUsernameAndPassword(string username, string password)
        {
            _loginPage.EnterUsername(username);
            _loginPage.EnterPassword(password);
        }

        [When("I click on the login button")]
        public void WhenIClickOnTheLoginButton()
        {
            _loginPage.ClickLoginButton();
        }

        [Then("I should be redirected to the inventory page")]
        public void ThenIShouldBeRedirectedToTheInventoryPage()
        {
            _driver.Url.Should().Contain("/inventory.html");
        }
    }
}