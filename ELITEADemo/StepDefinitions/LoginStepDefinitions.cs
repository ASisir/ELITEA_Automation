using OpenQA.Selenium;
using PageObjects;
using Utilities;

namespace ELITEADemo.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private readonly LoginPage _loginPage;
        private readonly DriverHelper _driverHelper;

        public LoginStepDefinitions(LoginPage loginPage, DriverHelper driverHelper)
        {
            _loginPage = loginPage;
            _driverHelper = driverHelper;
        }

        [Given("I am on the Sauce Demo login page")]
        public void GivenIAmOnTheSauceDemoLoginPage()
        {
            _driverHelper.NavigateTo("https://www.saucedemo.com");
        }

        [When("I enter valid username '(.*)' and password '(.*)'")]
        public void WhenIEnterValidUsernameAndPassword(string username, string password)
        {
            _loginPage.EnterUsername(username);
            _loginPage.EnterPassword(password);
        }

        [When("I click on the login button")]
        public void WhenIClickOnTheLoginButton()
        {
            _loginPage.ClickLoginButton();
        }

        [Then("I should be redirected to the products page")]
        public void ThenIShouldBeRedirectedToTheProductsPage()
        {
            _driverHelper.AssertUrlContains("/inventory.html");
        }

        [Then("I should see an error message")]
        public void ThenIShouldSeeAnErrorMessage()
        {
            _driverHelper.AssertElementExists(_loginPage.ErrorMessage);
        }
    }
}