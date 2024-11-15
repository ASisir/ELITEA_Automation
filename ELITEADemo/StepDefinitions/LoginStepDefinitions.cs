using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using ELITEADemo.PageObjects;

namespace ELITEADemo.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private readonly LoginPage _loginPage;

        public LoginStepDefinitions()
        {
            _loginPage = new LoginPage(UtilHelper.Driver);
        }

        [Given("I navigate to the Sauce Demo login page")]
        public void GivenINavigateToTheSauceDemoLoginPage()
        {
            _loginPage.NavigateToLoginPage();
        }

        [When("I enter username "(.*)" and password "(.*)"")]
        public void WhenIEnterUsernameAndPassword(string username, string password)
        {
            _loginPage.Login(username, password);
        }

        [Then("I should be redirected to the inventory page")]
        public void ThenIShouldBeRedirectedToTheInventoryPage()
        {
            _loginPage.VerifySuccessfulLogin();
        }
    }
}