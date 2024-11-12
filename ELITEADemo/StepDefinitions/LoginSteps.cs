[Given(@"I am on the Sauce Demo login page")]
public void GivenIAmOnTheSauceDemoLoginPage()
{
    driver.Navigate().GoToUrl("https://www.saucedemo.com");
}

[When(@"I enter '(.*)' as username and '(.*)' as password")]
public void WhenIEnterAsUsernameAndAsPassword(string username, string password)
{
    driver.FindElement(By.Id("user-name")).SendKeys(username);
    driver.FindElement(By.Id("password")).SendKeys(password);
}

[When(@"I click on the login button")]
public void WhenIClickOnTheLoginButton()
{
    driver.FindElement(By.Id("login-button")).Click();
}

[Then(@"I should be redirected to the inventory page")]
public void ThenIShouldBeRedirectedToTheInventoryPage()
{
    Assert.AreEqual("https://www.saucedemo.com/inventory.html", driver.Url);
}