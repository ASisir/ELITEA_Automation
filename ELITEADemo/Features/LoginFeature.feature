Feature: Login to Sauce Demo

Scenario: Successful login with valid credentials
Given User is on the Sauce Demo login page
When User enters valid username and password
And User clicks on the login button
Then User should be redirected to the home page

Scenario: Unsuccessful login with invalid credentials
Given User is on the Sauce Demo login page
When User enters invalid username and password
And User clicks on the login button
Then User should see an error message

Scenario: Unsuccessful login with empty credentials
Given User is on the Sauce Demo login page
When User leaves the username and password fields empty
And User clicks on the login button
Then User should see an error message

Scenario: Successful logout from the Sauce Demo
Given User is logged in to the Sauce Demo
When User clicks on the logout button
Then User should be redirected to the login page

Scenario: Remember credentials for future logins
Given User is on the Sauce Demo login page
When User enters valid username and password
And User checks the remember me checkbox
And User clicks on the login button
Then User's credentials should be remembered for future logins