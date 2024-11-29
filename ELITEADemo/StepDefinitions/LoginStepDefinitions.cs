using OpenQA.Selenium;
using TechTalk.SpecFlow;
using SauceDemo.PageObjects;

namespace SauceDemo.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private IWebDriver _driver;
        private LoginPage _loginPage;

        public LoginStepDefinitions(IWebDriver driver)
        {
            _driver = driver;
            _loginPage = new LoginPage(_driver);
        }

        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            _driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [When(@"I enter valid credentials")]
        public void WhenIEnterValidCredentials()
        {
            _loginPage.EnterUsername("standard_user");
            _loginPage.EnterPassword("secret_sauce");
            _loginPage.ClickLoginButton();
        }

        [Then(@"I should be logged in successfully")]
        public void ThenIShouldBeLoggedInSuccessfully()
        {
            // Assert that user is logged in
        }
    }
}