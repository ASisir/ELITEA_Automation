using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using ELITEADemo.PageObjects;
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

        [Given("I navigate to the Sauce Demo login page")]
        public void GivenINavigateToTheSauceDemoLoginPage()
        {
            _driver.Navigate().GoToUrl("https://www.saucedemo.com");
        }

        [When("I enter username \"(.*)\" and password \"(.*)\"")]
        public void WhenIEnterUsernameAndPassword(string username, string password)
        {
            _loginPage.Login(username, password);
        }

        [Then("I should be redirected to the inventory page")]
        public void ThenIShouldBeRedirectedToTheInventoryPage()
        {
            // Implementation for verification
        }
    }
}