import org.openqa.selenium.WebDriver;
import org.openqa.selenium.support.PageFactory;
import PageObjects.LoginPage;
import Utilities.DriverHelper;

public class LoginStepDefinitions {

    private WebDriver driver = DriverHelper.getDriver();
    private LoginPage loginPage = PageFactory.initElements(driver, LoginPage.class);

    @Given("^I am on the login page$")
    public void i_am_on_the_login_page() {
        driver.get("https://www.saucedemo.com");
    }

    @When("^I enter valid username '(.*)' and password '(.*)'$")
    public void i_enter_valid_username_and_password(String username, String password) {
        loginPage.enterUsername(username);
        loginPage.enterPassword(password);
    }

    @When("^I click on the login button$")
    public void i_click_on_the_login_button() {
        loginPage.clickLoginButton();
    }

    @Then("^I should be redirected to the products page$")
    public void i_should_be_redirected_to_the_products_page() {
        assert driver.getCurrentUrl().contains("/inventory.html");
    }

    @Then("^I should see an error message 'Invalid username or password'$")
    public void i_should_see_an_error_message() {
        assert loginPage.getErrorMessage().contains("Invalid username or password");
    }
}