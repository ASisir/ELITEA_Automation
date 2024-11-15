using OpenQA.Selenium;

namespace PageObjects
{
    public class LoginPage
    {
        private IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement UsernameInput => _driver.FindElement(By.XPath("//input[@id='user-name']"));
        private IWebElement PasswordInput => _driver.FindElement(By.XPath("//input[@id='password']"));
        private IWebElement LoginButton => _driver.FindElement(By.XPath("//input[@id='login-button']"));

        public void NavigateToLoginPage()
        {
            _driver.Navigate().GoToUrl("https://www.saucedemo.com");
        }

        public void EnterUsername(string username)
        {
            UsernameInput.SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            PasswordInput.SendKeys(password);
        }

        public void ClickLoginButton()
        {
            LoginButton.Click();
        }

        public void VerifySuccessfulLogin()
        {
            // Implementation for verifying successful login goes here
        }

        public void VerifyLoginErrorMessage()
        {
            // Implementation for verifying login error message goes here
        }

        public void VerifyLoginButtonIsDisabled()
        {
            // Implementation for verifying login button is disabled goes here
        }
    }
}