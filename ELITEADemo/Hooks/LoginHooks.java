import org.junit.Before;
import org.junit.After;
import Utilities.DriverHelper;

public class LoginHooks {

    @Before
    public void setUp() {
        DriverHelper.getDriver();
    }

    @After

    public void tearDown() {
        DriverHelper.closeDriver();
    }
}