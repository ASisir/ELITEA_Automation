using TechTalk.SpecFlow;

[Binding]
public class LoginHooks
{
    private readonly ScenarioContext _scenarioContext;
    private IWebDriver _driver;

    public LoginHooks(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [BeforeScenario]
    public void BeforeScenario()
    {
        _driver = DriverHelper.InitializeDriver();
        _scenarioContext["WebDriver"] = _driver;
    }

    [AfterScenario]
    public void AfterScenario()
    {
        _driver.Quit();
    }
}