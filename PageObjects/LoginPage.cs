using OpenQA.Selenium;

public class LoginPage
{
    private readonly IWebDriver _driver;
    private readonly By _usernameField = By.XPath("//input[@id='user-name']");
    private readonly By _passwordField = By.XPath("//input[@id='password']");
    private readonly By _loginButton = By.XPath("//input[@id='login-button']");

    public LoginPage(IWebDriver driver)
    {
        _driver = driver;
    }

    public void EnterUsername(string username)
    {
        _driver.FindElement(_usernameField).SendKeys(username);
    }

    public void EnterPassword(string password)
    {
        _driver.FindElement(_passwordField).SendKeys(password);
    }

    public void ClickLogin()
    {
        _driver.FindElement(_loginButton).Click();
    }
}