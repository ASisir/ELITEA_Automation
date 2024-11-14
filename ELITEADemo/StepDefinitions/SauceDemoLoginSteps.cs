using TechTalk.SpecFlow;
using PageObjects;

[Binding]
public class SauceDemoLoginSteps
{
    private readonly LoginPage loginPage;

    public SauceDemoLoginSteps()
    {
        loginPage = new LoginPage();
    [When("User enters invalid username and password")]
    public void WhenUserEntersInvalidUsernameAndPassword()
    {
        loginPage.Login("invalid_user", "invalid_password");
    }

    [Then("User should not be able to login")]
    public void ThenUserShouldNotBeAbleToLogin()
    {
        Assert.IsFalse(loginPage.IsLoggedIn());
    }

    [Given("User is logged in")]
    public void GivenUserIsLoggedIn()
    {
        loginPage.Login("standard_user", "secret_sauce");
        Assert.IsTrue(loginPage.IsLoggedIn());
    }

    [When("User clicks on Logout button")]
    public void WhenUserClicksOnLogoutButton()
    {
        loginPage.Logout();
    }

    [Then("User should be logged out")]
    public void ThenUserShouldBeLoggedOut()
    {
        Assert.IsFalse(loginPage.IsLoggedIn());
    }

    [When("User enters valid username and password and clicks on Remember me")]
    public void WhenUserEntersValidUsernameAndPasswordAndClicksOnRememberMe()
    {
        loginPage.Login("standard_user", "secret_sauce", true);
    }

    [Then("User's credentials should be remembered")]
    public void ThenUserSCredentialsShouldBeRemembered()
    {
        Assert.IsTrue(loginPage.AreCredentialsRemembered());
    }

    [When("User clicks on Forget me")]
    public void WhenUserClicksOnForgetMe()
    {
        loginPage.ForgetCredentials();
    }

    [Then("User's credentials should be forgotten")]
    public void ThenUserSCredentialsShouldBeForgotten()
    {
        Assert.IsFalse(loginPage.AreCredentialsRemembered());
    }
}

    [Given("User is on Login Page")]
    public void GivenUserIsOnLoginPage()
    {
        loginPage.GoTo();
    [When("User enters invalid username and password")]
    public void WhenUserEntersInvalidUsernameAndPassword()
    {
        loginPage.Login("invalid_user", "invalid_password");
    }

    [Then("User should not be able to login")]
    public void ThenUserShouldNotBeAbleToLogin()
    {
        Assert.IsFalse(loginPage.IsLoggedIn());
    }

    [Given("User is logged in")]
    public void GivenUserIsLoggedIn()
    {
        loginPage.Login("standard_user", "secret_sauce");
        Assert.IsTrue(loginPage.IsLoggedIn());
    }

    [When("User clicks on Logout button")]
    public void WhenUserClicksOnLogoutButton()
    {
        loginPage.Logout();
    }

    [Then("User should be logged out")]
    public void ThenUserShouldBeLoggedOut()
    {
        Assert.IsFalse(loginPage.IsLoggedIn());
    }

    [When("User enters valid username and password and clicks on Remember me")]
    public void WhenUserEntersValidUsernameAndPasswordAndClicksOnRememberMe()
    {
        loginPage.Login("standard_user", "secret_sauce", true);
    }

    [Then("User's credentials should be remembered")]
    public void ThenUserSCredentialsShouldBeRemembered()
    {
        Assert.IsTrue(loginPage.AreCredentialsRemembered());
    }

    [When("User clicks on Forget me")]
    public void WhenUserClicksOnForgetMe()
    {
        loginPage.ForgetCredentials();
    }

    [Then("User's credentials should be forgotten")]
    public void ThenUserSCredentialsShouldBeForgotten()
    {
        Assert.IsFalse(loginPage.AreCredentialsRemembered());
    }
}

    [When("User enters valid username and password")]
    public void WhenUserEntersValidUsernameAndPassword()
    {
        loginPage.Login("standard_user", "secret_sauce");
    [When("User enters invalid username and password")]
    public void WhenUserEntersInvalidUsernameAndPassword()
    {
        loginPage.Login("invalid_user", "invalid_password");
    }

    [Then("User should not be able to login")]
    public void ThenUserShouldNotBeAbleToLogin()
    {
        Assert.IsFalse(loginPage.IsLoggedIn());
    }

    [Given("User is logged in")]
    public void GivenUserIsLoggedIn()
    {
        loginPage.Login("standard_user", "secret_sauce");
        Assert.IsTrue(loginPage.IsLoggedIn());
    }

    [When("User clicks on Logout button")]
    public void WhenUserClicksOnLogoutButton()
    {
        loginPage.Logout();
    }

    [Then("User should be logged out")]
    public void ThenUserShouldBeLoggedOut()
    {
        Assert.IsFalse(loginPage.IsLoggedIn());
    }

    [When("User enters valid username and password and clicks on Remember me")]
    public void WhenUserEntersValidUsernameAndPasswordAndClicksOnRememberMe()
    {
        loginPage.Login("standard_user", "secret_sauce", true);
    }

    [Then("User's credentials should be remembered")]
    public void ThenUserSCredentialsShouldBeRemembered()
    {
        Assert.IsTrue(loginPage.AreCredentialsRemembered());
    }

    [When("User clicks on Forget me")]
    public void WhenUserClicksOnForgetMe()
    {
        loginPage.ForgetCredentials();
    }

    [Then("User's credentials should be forgotten")]
    public void ThenUserSCredentialsShouldBeForgotten()
    {
        Assert.IsFalse(loginPage.AreCredentialsRemembered());
    }
}

    [Then("User should be able to login successfully")]
    public void ThenUserShouldBeAbleToLoginSuccessfully()
    {
        Assert.IsTrue(loginPage.IsLoggedIn());
    [When("User enters invalid username and password")]
    public void WhenUserEntersInvalidUsernameAndPassword()
    {
        loginPage.Login("invalid_user", "invalid_password");
    }

    [Then("User should not be able to login")]
    public void ThenUserShouldNotBeAbleToLogin()
    {
        Assert.IsFalse(loginPage.IsLoggedIn());
    }

    [Given("User is logged in")]
    public void GivenUserIsLoggedIn()
    {
        loginPage.Login("standard_user", "secret_sauce");
        Assert.IsTrue(loginPage.IsLoggedIn());
    }

    [When("User clicks on Logout button")]
    public void WhenUserClicksOnLogoutButton()
    {
        loginPage.Logout();
    }

    [Then("User should be logged out")]
    public void ThenUserShouldBeLoggedOut()
    {
        Assert.IsFalse(loginPage.IsLoggedIn());
    }

    [When("User enters valid username and password and clicks on Remember me")]
    public void WhenUserEntersValidUsernameAndPasswordAndClicksOnRememberMe()
    {
        loginPage.Login("standard_user", "secret_sauce", true);
    }

    [Then("User's credentials should be remembered")]
    public void ThenUserSCredentialsShouldBeRemembered()
    {
        Assert.IsTrue(loginPage.AreCredentialsRemembered());
    }

    [When("User clicks on Forget me")]
    public void WhenUserClicksOnForgetMe()
    {
        loginPage.ForgetCredentials();
    }

    [Then("User's credentials should be forgotten")]
    public void ThenUserSCredentialsShouldBeForgotten()
    {
        Assert.IsFalse(loginPage.AreCredentialsRemembered());
    }
}
[When("User enters invalid username and password")]
    public void WhenUserEntersInvalidUsernameAndPassword()
    {
        loginPage.Login("invalid_user", "invalid_password");
    }

    [Then("User should not be able to login")]
    public void ThenUserShouldNotBeAbleToLogin()
    {
        Assert.IsFalse(loginPage.IsLoggedIn());
    }

    [Given("User is logged in")]
    public void GivenUserIsLoggedIn()
    {
        loginPage.Login("standard_user", "secret_sauce");
        Assert.IsTrue(loginPage.IsLoggedIn());
    }

    [When("User clicks on Logout button")]
    public void WhenUserClicksOnLogoutButton()
    {
        loginPage.Logout();
    }

    [Then("User should be logged out")]
    public void ThenUserShouldBeLoggedOut()
    {
        Assert.IsFalse(loginPage.IsLoggedIn());
    }

    [When("User enters valid username and password and clicks on Remember me")]
    public void WhenUserEntersValidUsernameAndPasswordAndClicksOnRememberMe()
    {
        loginPage.Login("standard_user", "secret_sauce", true);
    }

    [Then("User's credentials should be remembered")]
    public void ThenUserSCredentialsShouldBeRemembered()
    {
        Assert.IsTrue(loginPage.AreCredentialsRemembered());
    }

    [When("User clicks on Forget me")]
    public void WhenUserClicksOnForgetMe()
    {
        loginPage.ForgetCredentials();
    }

    [Then("User's credentials should be forgotten")]
    public void ThenUserSCredentialsShouldBeForgotten()
    {
        Assert.IsFalse(loginPage.AreCredentialsRemembered());
    }
}