Feature: Sauce Demo Login

Scenario: Successful Login with Valid Credentials
Given User is on Sauce Demo Login Page
When User enters valid username and password
And User clicks on Login button
Then User should be redirected to the Home Page

Scenario: Unsuccessful Login with Invalid Credentials
Given User is on Sauce Demo Login Page
When User enters invalid username and password
And User clicks on Login button
Then User should see an error message

Scenario: Unsuccessful Login with Empty Credentials
Given User is on Sauce Demo Login Page
When User leaves username and password fields empty
And User clicks on Login button
Then User should see an error message

Scenario: Successful Logout from Application
Given User is logged in Sauce Demo
When User clicks on Logout button
Then User should be redirected to the Login Page

Scenario: Remember Credentials for Future Logins
Given User is on Sauce Demo Login Page
When User enters valid username and password
And User checks the Remember Me checkbox
And User clicks on Login button
Then User credentials should be remembered for future logins