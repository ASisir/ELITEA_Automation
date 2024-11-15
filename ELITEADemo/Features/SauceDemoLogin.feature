Feature: Sauce Demo Login

Scenario: Successful Login with Valid Credentials
Given User is on the Sauce Demo Login Page
When User enters valid username and password
And User clicks on the Login button
Then User should be redirected to the Sauce Demo Home Page

Scenario: Unsuccessful Login with Invalid Credentials
Given User is on the Sauce Demo Login Page
When User enters invalid username and password
And User clicks on the Login button
Then User should see an error message

Scenario: Unsuccessful Login with Empty Credentials
Given User is on the Sauce Demo Login Page
When User leaves username and password fields empty
And User clicks on the Login button
Then User should see an error message

Scenario: Successful Logout from the Sauce Demo Home Page
Given User is logged in and on the Sauce Demo Home Page
When User clicks on the Logout button
Then User should be redirected to the Sauce Demo Login Page

Scenario: Remember Credentials for Future Logins
Given User is on the Sauce Demo Login Page
When User enters valid username and password
And User checks the Remember Me checkbox
And User clicks on the Login button
Then User should be redirected to the Sauce Demo Home Page
And User's credentials should be remembered for future logins