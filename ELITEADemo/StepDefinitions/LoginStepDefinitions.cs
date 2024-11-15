using System;
using OpenQA.Selenium;
using ELITEADemo.PageObjects;
using ELITEADemo.Utilities;

namespace ELITEADemo.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private readonly IWebDriver _driver;
        private readonly LoginPage _loginPage;

        public LoginStepDefinitions()
        {
            _driver = UtilHelper.InitializeWebDriver();
            _loginPage = new LoginPage(_driver);
        }

        [Given("I navigate to the Sauce Demo login page")]
        public void GivenINavigateToTheSauceDemoLoginPage()
        {
            _loginPage.NavigateTo();
        }

        [When("I enter username '(.*)' and password '(.*)'")]
        public void WhenIEnterUsernameAndPassword(string username, string password)
        {
            _loginPage.EnterUsername(username);
            _loginPage.EnterPassword(password);
        }

        [And("I click on the login button")]
        public void AndIClickOnTheLoginButton()
        {
            _loginPage.ClickLoginButton();
        }

        [Then("I should be redirected to the products page")]
        public void ThenIShouldBeRedirectedToTheProductsPage()
        {
            // Verification logic here
        }
    }
}