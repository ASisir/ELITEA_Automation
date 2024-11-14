Feature: SauceDemo

Scenario: Login with valid credentials
Given User is on the login page
When User enters valid username and password
And User clicks on login button
Then User should be redirected to the home page

Scenario: Login with invalid credentials
Given User is on the login page
When User enters invalid username and password
And User clicks on login button
Then User should see an error message