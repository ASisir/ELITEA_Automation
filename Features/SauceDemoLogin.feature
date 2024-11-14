Feature: Sauce Demo Login

Scenario: Successful Login with Valid Credentials
Given User is on the Sauce Demo Login Page
When User enters valid username and password
And User clicks on the Login button
Then User should be navigated to the Home Page

Scenario: Unsuccessful Login with Invalid Credentials
Given User is on the Sauce Demo Login Page
When User enters invalid username and password
And User clicks on the Login button
Then User should see an error message

Scenario: Unsuccessful Login with Empty Credentials
Given User is on the Sauce Demo Login Page
When User leaves the username and password fields empty
And User clicks on the Login button
Then User should see an error message

Scenario: Successful Logout from the Application
Given User is logged in to the Sauce Demo Application
When User clicks on the Logout button
Then User should be navigated back to the Login Page

Scenario: Remember Credentials Feature
Given User is on the Sauce Demo Login Page
When User enters valid username and password
And User clicks on the Remember Me checkbox
And User clicks on the Login button
Then User should be navigated to the Home Page
And User's credentials should be remembered for the next login