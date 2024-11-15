Feature: Login to Sauce Demo

Scenario: Successful Login with Valid Credentials
Given User is on the Sauce Demo Login Page
When User enters valid username and password
And User clicks on Login button
Then User should be redirected to the Home Page

Scenario: Unsuccessful Login with Invalid Credentials
Given User is on the Sauce Demo Login Page
When User enters invalid username and password
And User clicks on Login button
Then User should see an error message

Scenario: Unsuccessful Login with Empty Credentials
Given User is on the Sauce Demo Login Page
When User leaves the username and password fields empty
And User clicks on Login button
Then User should see an error message

Scenario: Successful Logout from the Home Page
Given User is logged into the Sauce Demo
When User clicks on the Logout button
Then User should be redirected to the Login Page

Scenario: Remember Credentials for Future Logins
Given User is on the Sauce Demo Login Page
When User enters valid username and password
And User clicks on Remember Me checkbox
And User clicks on Login button
Then User's credentials should be remembered for future logins