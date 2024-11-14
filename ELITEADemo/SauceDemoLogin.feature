Feature: SauceDemo Login

Scenario: Successful Login with valid credentials
Given User is on Login Page
When User enters valid username and password
Then User should be able to login successfully

Scenario: Unsuccessful Login with invalid credentials
Given User is on Login Page
When User enters invalid username and password
Then User should not be able to login

Scenario: Successful Logout
Given User is logged in
When User clicks on Logout button
Then User should be logged out

Scenario: Remember credentials
Given User is on Login Page
When User enters valid username and password and clicks on Remember me
Then User's credentials should be remembered

Scenario: Forget credentials
Given User's credentials are remembered
When User clicks on Forget me
Then User's credentials should be forgotten