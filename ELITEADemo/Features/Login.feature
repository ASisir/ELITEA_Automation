Feature: Login

Scenario: Successful Login with valid credentials
Given User is on Login Page
When User enters valid username and password
And User clicks on Login button
Then User should be navigated to the home page

Scenario: Unsuccessful Login with invalid credentials
Given User is on Login Page
When User enters invalid username and password
And User clicks on Login button
Then User should see an error message

Scenario: Unsuccessful Login with empty credentials
Given User is on Login Page
When User leaves username and password fields empty
And User clicks on Login button
Then User should see an error message

Scenario: Successful Logout
Given User is logged in
When User clicks on Logout button
Then User should be navigated back to the Login page

Scenario: Remember credentials
Given User is on Login Page
When User enters valid username and password
And User clicks on Remember me checkbox
And User clicks on Login button
Then User should be navigated to the home page
And User's credentials should be remembered