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

        public IWebElement Username => _driver.FindElement(By.XPath("//input[@id='user-name']"));
        public IWebElement Password => _driver.FindElement(By.XPath("//input[@id='password']"));
        public IWebElement LoginButton => _driver.FindElement(By.XPath("//input[@id='login-button']"));

        public void EnterUsernameAndPassword(string username, string password)
        {
            Username.SendKeys(username);
            Password.SendKeys(password);
        }

        public void ClickLoginButton()
        {
            LoginButton.Click();
        }
    }
}