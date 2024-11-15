using System;
using OpenQA.Selenium;
using ELITEADemo.Utilities;

namespace ELITEADemo.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private readonly IWebDriver _driver;
        private readonly LoginPage _loginPage;

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

        [When("I enter username '(.*)' and password '(.*)'")]
        public void WhenIEnterUsernameAndPassword(string username, string password)
        {
            _loginPage.EnterUsernameAndPassword(username, password);
        }

        [When("I click on the login button")]
        public void WhenIClickOnTheLoginButton()
        {
            _loginPage.ClickLoginButton();
        }

        [Then("I should be redirected to the products page")]
        public void ThenIShouldBeRedirectedToTheProductsPage()
        {
            // Implementation for verification goes here
        }
    }
}