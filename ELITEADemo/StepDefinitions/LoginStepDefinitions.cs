using ELITEADemo.PageObjects;
using ELITEADemo.Utilities;
using TechTalk.SpecFlow;

namespace ELITEADemo.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private LoginPage loginPage;
        private UtilHelper utilHelper;

        public LoginStepDefinitions()
        {
            utilHelper = new UtilHelper();
            loginPage = new LoginPage(utilHelper.driver);
        }

        [Given(@"I navigate to the login page")]
        public void GivenINavigateToTheLoginPage()
        {
            utilHelper.NavigateToUrl("your_login_url");
        }

        [When(@"I enter username and password")]
        public void WhenIEnterUsernameAndPassword()
        {
            loginPage.EnterUsername("your_username");
            loginPage.EnterPassword("your_password");
        }

        [When(@"I click login button")]
        public void WhenIClickLoginButton()
        {
            loginPage.ClickLoginButton();
        }

        [Then(@"I should be logged in")]
        public void ThenIShouldBeLoggedIn()
        {
            // Assert login success
        }
    }
}