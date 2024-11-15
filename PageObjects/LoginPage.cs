using OpenQA.Selenium;

namespace ELITEADemo.PageObjects
{
    public class LoginPage
    {
        private IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void NavigateTo()
        {
            _driver.Navigate().GoToUrl("https://www.saucedemo.com");
        }

        public void EnterUsername(string username)
        {
            _driver.FindElement(By.XPath("//input[@id='user-name']")).SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            _driver.FindElement(By.XPath("//input[@id='password']")).SendKeys(password);
        }

        public void ClickLoginButton()
        {
            _driver.FindElement(By.XPath("//input[@id='login-button']")).Click();
        }
    }
}