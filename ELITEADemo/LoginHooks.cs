using TechTalk.SpecFlow;

[Binding]
public class LoginHooks
{
    private readonly DriverHelper _driverHelper;

    public LoginHooks(DriverHelper driverHelper)
    {
        _driverHelper = driverHelper;
    }

    [BeforeScenario]
    public void BeforeScenario()
    {
        _driverHelper.InitializeDriver();
    }

    [AfterScenario]
    public void AfterScenario()
    {
        _driverHelper.CloseDriver();
    }
}