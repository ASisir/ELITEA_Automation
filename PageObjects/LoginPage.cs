using OpenQA.Selenium;

namespace PageObjects
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement Username => _driver.FindElement(By.XPath("//input[@id='user-name']"));
        public IWebElement Password => _driver.FindElement(By.XPath("//input[@id='password']"));
        public IWebElement LoginButton => _driver.FindElement(By.XPath("//input[@id='login-button']"));

        public void EnterUsername(string username)
        {
            Username.SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            Password.SendKeys(password);
        }

        public void ClickLoginButton()
        {
            LoginButton.Click();
        }
    }
}