using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ELITEADemo.Pages;

namespace ELITEADemo.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private IWebDriver driver;
        private LoginPage loginPage;

        [Given("User is on Login Page")]
        public void GivenUserIsOnLoginPage()
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

        [When("User clicks on Login button")]
        public void WhenUserClicksOnLoginButton()
        {
            loginPage.ClickLogin();
        }

        [Then("User should be navigated to the home page")]
        public void ThenUserShouldBeNavigatedToTheHomePage()
        {
            // Assert that user is navigated to the home page
        }

        // Implement remaining steps similarly

        [AfterScenario]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}