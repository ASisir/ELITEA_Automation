using OpenQA.Selenium;

namespace ELITEADemo.PageObjects
{
    public class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement UsernameField => driver.FindElement(By.XPath("//input[@id='user-name']"));
        public IWebElement PasswordField => driver.FindElement(By.XPath("//input[@id='password']"));
        public IWebElement LoginButton => driver.FindElement(By.XPath("//input[@id='login-button']"));

        public void EnterUsername(string username)
        {
            UsernameField.SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            PasswordField.SendKeys(password);
        }

        public void ClickLoginButton()
        {
            LoginButton.Click();
        }
    }
}