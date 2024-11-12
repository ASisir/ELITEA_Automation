Feature: Login

Scenario: Successful Login with valid credentials
Given User is on the Sauce Demo Login Page
When User enters 'standard_user' as username and 'secret_sauce' as password
And User clicks on the Login button
Then User should be redirected to the Products page

Scenario: Successful Login with visual_user credentials
Given User is on the Sauce Demo Login Page
When User enters 'visual_user' as username and 'secret_sauce' as password
And User clicks on the Login button
Then User should be redirected to the Products page

Scenario: Unsuccessful Login with invalid credentials
Given User is on the Sauce Demo Login Page
When User enters 'invalid_user' as username and 'invalid_password' as password
And User clicks on the Login button
Then User should see an error message

Scenario: Unsuccessful Login with empty username
Given User is on the Sauce Demo Login Page
When User leaves the username field empty and enters 'secret_sauce' as password
And User clicks on the Login button
Then User should see an error message

Scenario: Unsuccessful Login with empty password
Given User is on the Sauce Demo Login Page
When User enters 'standard_user' as username and leaves the password field empty
And User clicks on the Login button
Then User should see an error message