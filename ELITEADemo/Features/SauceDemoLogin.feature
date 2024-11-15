Feature: Login to Sauce Demo

Scenario: Successful Login with Valid Credentials
Given User is on the Sauce Demo login page
When User enters valid username and password
And User clicks on the login button
Then User should be redirected to the home page

Scenario: Unsuccessful Login with Invalid Credentials
Given User is on the Sauce Demo login page
When User enters invalid username and password
And User clicks on the login button
Then User should see an error message

Scenario: Unsuccessful Login with Empty Credentials
Given User is on the Sauce Demo login page
When User leaves the username and password fields empty
And User clicks on the login button
Then User should see an error message

Scenario: Successful Logout from the Application
Given User is logged into the Sauce Demo application
When User clicks on the logout button
Then User should be redirected to the login page

Scenario: Remember Me Option Functionality
Given User is on the Sauce Demo login page
When User enters valid credentials and checks the Remember Me option
And User clicks on the login button and then logs out
Then User should see the username field pre-filled with the username on the login page