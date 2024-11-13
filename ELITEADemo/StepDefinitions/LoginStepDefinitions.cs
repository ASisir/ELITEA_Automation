using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ELITEADemo.PageObjects;

namespace ELITEADemo.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private IWebDriver driver;
        private LoginPage loginPage;

        [Given("I am on the login page of Sauce Demo")]
        public void GivenIAmOnTheLoginPageOfSauceDemo()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl('https://www.saucedemo.com');
            loginPage = new LoginPage(driver);
        }

        [When("I enter '(.*)' as username and '(.*)' as password")]
        public void WhenIEnterAsUsernameAndAsPassword(string username, string password)
        {
            loginPage.EnterUsername(username);
            loginPage.EnterPassword(password);
        }

        [When("I click on the login button")]
        public void WhenIClickOnTheLoginButton()
        {
            loginPage.ClickLogin();
        }

        [Then("I should be redirected to the home page")]
        public void ThenIShouldBeRedirectedToTheHomePage()
        {
            // Assertion code here
        }

        [Then("I should see an error message")]
        public void ThenIShouldSeeAnErrorMessage()
        {
            // Assertion code here
        }
    }
}