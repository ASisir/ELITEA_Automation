Feature: SauceDemo Login

Scenario: Successful login with valid credentials
Given User is at the SauceDemo login page
When User enters valid username and password
And User clicks on login button
Then User should be redirected to the home page

Scenario: Unsuccessful login with invalid username
Given User is at the SauceDemo login page
When User enters invalid username and valid password
And User clicks on login button
Then User should see an error message

Scenario: Unsuccessful login with invalid password
Given User is at the SauceDemo login page
When User enters valid username and invalid password
And User clicks on login button
Then User should see an error message

Scenario: Unsuccessful login with empty username
Given User is at the SauceDemo login page
When User leaves the username field empty and enters valid password
And User clicks on login button
Then User should see an error message

Scenario: Unsuccessful login with empty password
Given User is at the SauceDemo login page
When User enters valid username and leaves the password field empty
And User clicks on login button
Then User should see an error message