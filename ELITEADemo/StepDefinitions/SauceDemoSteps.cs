using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ELITEADemo.PageObjects;

namespace ELITEADemo.StepDefinitions
{
    [Binding]
    public class SauceDemoSteps
    {
        IWebDriver driver;
        LoginPage loginPage;

        [Given("User is on the login page")]
        public void GivenUserIsOnTheLoginPage()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com");
            loginPage = new LoginPage(driver);
        }

        [When("User enters valid username and password")]
        public void WhenUserEntersValidUsernameAndPassword()
        {
            loginPage.EnterUsername("standard_user");
            loginPage.EnterPassword("secret_sauce");
        }

        [When("User enters invalid username and password")]
        public void WhenUserEntersInvalidUsernameAndPassword()
        {
            loginPage.EnterUsername("invalid_user");
            loginPage.EnterPassword("invalid_password");
        }

        [When("User clicks on login button")]
        public void WhenUserClicksOnLoginButton()
        {
            loginPage.ClickLoginButton();
        }

        [Then("User should be redirected to the home page")]
        public void ThenUserShouldBeRedirectedToTheHomePage()
        {
            // Assertion code here
        }

        [Then("User should see an error message")]
        public void ThenUserShouldSeeAnErrorMessage()
        {
            // Assertion code here
        }
    }
}