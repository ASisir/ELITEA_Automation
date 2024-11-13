public class LoginPage
{
    private IWebDriver driver;
    private By username = By.Id("user-name");
    private By password = By.Id("password");
    private By loginButton = By.Id("login-button");

    public LoginPage(IWebDriver driver)
    {
        this.driver = driver;
    }

    public void EnterUsername(string username)
    {
        driver.FindElement(this.username).SendKeys(username);
    }

    public void EnterPassword(string password)
    {
        driver.FindElement(this.password).SendKeys(password);
    }

    public void ClickLoginButton()
    {
        driver.FindElement(this.loginButton).Click();
    }
}