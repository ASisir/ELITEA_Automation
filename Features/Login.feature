Feature: Login

Scenario: Successful Login with Valid Credentials
Given User is on Login Page
When User enters valid username and password
And Clicks on Login button
Then User should be redirected to the Home Page

Scenario: Unsuccessful Login with Invalid Credentials
Given User is on Login Page
When User enters invalid username and password
And Clicks on Login button
Then User should see an error message

Scenario: Unsuccessful Login with Empty Username
Given User is on Login Page
When User leaves the username field empty and enters valid password
And Clicks on Login button
Then User should see an error message

Scenario: Unsuccessful Login with Empty Password
Given User is on Login Page
When User enters valid username and leaves the password field empty
And Clicks on Login button
Then User should see an error message

Scenario: Remember credentials functionality
Given User is on Login Page
When User enters valid username and password
And User clicks on Remember Me checkbox
And Clicks on Login button
Then User should be redirected to the Home Page
And User's credentials should be remembered when User revisits the Login Page