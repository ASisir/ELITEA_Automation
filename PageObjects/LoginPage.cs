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

        private IWebElement UsernameField => _driver.FindElement(By.XPath("//input[@id='user-name']"));
        private IWebElement PasswordField => _driver.FindElement(By.XPath("//input[@id='password']"));
        private IWebElement LoginButton => _driver.FindElement(By.XPath("//input[@id='login-button']"));

        public void Login(string username, string password)
        {
            UsernameField.SendKeys(username);
            PasswordField.SendKeys(password);
            LoginButton.Click();
        }
    }
}