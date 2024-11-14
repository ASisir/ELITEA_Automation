using OpenQA.Selenium;

namespace ELITEADemo.PageObjects
{
    public class LoginPage
    {
        private IWebDriver driver;
        private By usernameField = By.XPath("//input[@id='user-name']");
        private By passwordField = By.XPath("//input[@id='password']");
        private By loginButton = By.XPath("//input[@id='login-button']");

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void EnterUsername(string username)
        {
            driver.FindElement(usernameField).SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            driver.FindElement(passwordField).SendKeys(password);
        }

        public void ClickLoginButton()
        {
            driver.FindElement(loginButton).Click();
        }
    }
}