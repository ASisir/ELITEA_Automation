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

        public LoginStepDefinitions(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            _loginPage = new LoginPage(_driverHelper.Driver);
        }

        [Given("I navigate to the Sauce Demo login page")]
        public void GivenINavigateToTheSauceDemoLoginPage()
        {
            _loginPage.NavigateToLoginPage();
        }

        [When("I enter username '(.*)' and password '(.*)'")]
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

        [Then("I should be redirected to the products page")]
        public void ThenIShouldBeRedirectedToTheProductsPage()
        {
            _loginPage.VerifySuccessfulLogin();
        }

        [Then("I should see an error message")]
        public void ThenIShouldSeeAnErrorMessage()
        {
            _loginPage.VerifyLoginErrorMessage();
        }

        [Then("the login button should be disabled")]
        public void ThenTheLoginButtonShouldBeDisabled()
        {
            _loginPage.VerifyLoginButtonIsDisabled();
        }
    }
}