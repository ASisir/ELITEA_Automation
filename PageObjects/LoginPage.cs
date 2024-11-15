using OpenQA.Selenium;

namespace ELITEADemo.PageObjects
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;
        private readonly string _url = "https://www.saucedemo.com";

        private IWebElement TxtUsername => _driver.FindElement(By.XPath("//input[@id='user-name']"));
        private IWebElement TxtPassword => _driver.FindElement(By.XPath("//input[@id='password']"));
        private IWebElement BtnLogin => _driver.FindElement(By.XPath("//input[@id='login-button']"));

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void GoToUrl()
        {
            _driver.Navigate().GoToUrl(_url);
        }

        public void EnterUsername(string username)
        {
            TxtUsername.SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            TxtPassword.SendKeys(password);
        }

        public void ClickLoginButton()
        {
            BtnLogin.Click();
        }
    }
}