Feature: Login
Scenario: Successful Login with Valid Credentials
Given User is at the Login Page
When User enters Username as 'standard_user' and Password as 'secret_sauce'
And Clicks on the Login button
Then User should be redirected to the home page