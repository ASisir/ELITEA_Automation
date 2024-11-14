using OpenQA.Selenium;

namespace PageObjects
{
    public class LoginPage
    {
        private IWebDriver driver;

        private By usernameLocator = By.XPath("Login_Username");
        private By passwordLocator = By.XPath("Login_Password");
        private By loginButtonLocator = By.XPath("Login_Button");

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void EnterUsername(string username)
        {
            driver.FindElement(usernameLocator).SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            driver.FindElement(passwordLocator).SendKeys(password);
        }

        public void ClickLoginButton()
        {
            driver.FindElement(loginButtonLocator).Click();
        }
    }
}