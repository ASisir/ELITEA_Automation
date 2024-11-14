Feature: SauceDemo Login

Scenario: Successful Login with Valid Credentials
Given User is on SauceDemo Login Page
When User enters valid username and password
And User clicks on Login button
Then User should be navigated to the home page

Scenario: Unsuccessful Login with Invalid Credentials
Given User is on SauceDemo Login Page
When User enters invalid username and password
And User clicks on Login button
Then User should see an error message

Scenario: Unsuccessful Login with Empty Username
Given User is on SauceDemo Login Page
When User leaves the username field empty
And User clicks on Login button
Then User should see an error message

Scenario: Unsuccessful Login with Empty Password
Given User is on SauceDemo Login Page
When User leaves the password field empty
And User clicks on Login button
Then User should see an error message

Scenario: Remember Credentials
Given User is on SauceDemo Login Page
When User enters valid username and password
And User clicks on Remember Me checkbox
And User clicks on Login button
Then User should be navigated to the home page
And User's credentials should be remembered for next login