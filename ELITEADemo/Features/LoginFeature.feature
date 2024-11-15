Feature: Login to Sauce Demo

Scenario: Successful Login with Valid Credentials
Given User is on Sauce Demo Login Page
When User enters valid Username and Password
And User clicks on Login button
Then User should be navigated to the Home Page

Scenario: Unsuccessful Login with Invalid Credentials
Given User is on Sauce Demo Login Page
When User enters invalid Username and Password
And User clicks on Login button
Then User should see an error message

Scenario: Unsuccessful Login with Empty Credentials
Given User is on Sauce Demo Login Page
When User leaves Username and Password fields empty
And User clicks on Login button
Then User should see an error message

Scenario: Successful Logout from Application
Given User is logged in Sauce Demo
When User clicks on Logout button
Then User should be navigated back to the Login Page

Scenario: Remember Credentials
Given User is on Sauce Demo Login Page
When User enters valid Username and Password
And User clicks on Remember me checkbox
And User clicks on Login button
Then User should be navigated to the Home Page
And User's credentials should be remembered for next login