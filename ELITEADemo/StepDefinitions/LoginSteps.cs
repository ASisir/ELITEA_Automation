using OpenQA.Selenium;
using ELITEADemo.PageObjects;

namespace ELITEADemo.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private readonly IWebDriver _driver;
        private LoginPage _loginPage;

        public LoginSteps(IWebDriver driver)
        {
            _driver = driver;
            _loginPage = new LoginPage(_driver);
        }

        [Given("User is on Sauce Demo Login Page")]
        public void GivenUserIsOnSauceDemoLoginPage()
        {
            _loginPage.NavigateTo();
        }

        [When("User enters valid Username and Password")]
        public void WhenUserEntersValidUsernameAndPassword()
        {
            _loginPage.Login("standard_user", "secret_sauce");
        }

        [When("User enters invalid Username and Password")]
        public void WhenUserEntersInvalidUsernameAndPassword()
        {
            _loginPage.Login("invalid_user", "invalid_sauce");
        }

        [When("User leaves Username and Password fields empty")]
        public void WhenUserLeavesUsernameAndPasswordFieldsEmpty()
        {
            _loginPage.Login("", "");
        }

        [When("User clicks on Logout button")]
        public void WhenUserClicksOnLogoutButton()
        {
            _loginPage.Logout();
        }

        [When("User clicks on Remember me checkbox")]
        public void WhenUserClicksOnRememberMeCheckbox()
        {
            _loginPage.RememberMe();
        }

        [Then("User should be navigated to the Home Page")]
        public void ThenUserShouldBeNavigatedToTheHomePage()
        {
            Assert.IsTrue(_loginPage.IsHomePageDisplayed());
        }

        [Then("User should see an error message")]
        public void ThenUserShouldSeeAnErrorMessage()
        {
            Assert.IsTrue(_loginPage.IsErrorMessageDisplayed());
        }

        [Then("User's credentials should be remembered for next login")]
        public void ThenUsersCredentialsShouldBeRememberedForNextLogin()
        {
            Assert.IsTrue(_loginPage.IsCredentialsRemembered());
        }
    }
}