Feature: Sauce Demo Login

Scenario: Successful Login with Valid Credentials
Given User is on Sauce Demo Login Page
When User enters valid username and password
And Clicks on Login button
Then User should be redirected to the home page

Scenario: Unsuccessful Login with Invalid Credentials
Given User is on Sauce Demo Login Page
When User enters invalid username and password
And Clicks on Login button
Then User should see an error message

Scenario: Unsuccessful Login with Empty Credentials
Given User is on Sauce Demo Login Page
When User leaves username and password fields empty
And Clicks on Login button
Then User should see an error message

Scenario: Successful Logout from Application
Given User is logged into the application
When User clicks on Logout button
Then User should be redirected to the login page

Scenario: Remember Me functionality
Given User is on Sauce Demo Login Page
When User enters valid credentials and checks the Remember Me option
And Clicks on Login button
Then User should be redirected to the home page
And User's credentials should be remembered for the next login session