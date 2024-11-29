Feature: Login to Sauce Demo

Scenario: Login with valid credentials
Given User is on the login page of Sauce Demo
When User enters valid username and password
And User clicks on the login button
Then User should be redirected to the home page

Scenario: Login with invalid credentials
Given User is on the login page of Sauce Demo
When User enters invalid username and password
And User clicks on the login button
Then User should see an error message

Scenario: Login with empty credentials
Given User is on the login page of Sauce Demo
When User leaves the username and password field empty
And User clicks on the login button
Then User should see an error message

Scenario: Login with valid username but invalid password
Given User is on the login page of Sauce Demo
When User enters valid username and invalid password
And User clicks on the login button
Then User should see an error message

Scenario: Login with invalid username but valid password
Given User is on the login page of Sauce Demo
When User enters invalid username and valid password
And User clicks on the login button
Then User should see an error message