Feature: Login

Scenario: Successful login with standard user
Given User is on the login page
When User enters 'standard_user' as username and 'secret_sauce' as password
And User clicks on the login button
Then User should be redirected to the products page

Scenario: Successful login with visual user
Given User is on the login page
When User enters 'visual_user' as username and 'secret_sauce' as password
And User clicks on the login button
Then User should be redirected to the products page

Scenario: Unsuccessful login with incorrect username
Given User is on the login page
When User enters 'incorrect_user' as username and 'secret_sauce' as password
And User clicks on the login button
Then User should see an error message

Scenario: Unsuccessful login with incorrect password
Given User is on the login page
When User enters 'standard_user' as username and 'incorrect_password' as password
And User clicks on the login button
Then User should see an error message

Scenario: Unsuccessful login with empty credentials
Given User is on the login page
When User enters '' as username and '' as password
And User clicks on the login button
Then User should see an error message