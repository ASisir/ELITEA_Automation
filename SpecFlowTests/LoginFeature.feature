Feature: LoginFeature

Scenario: Successful Login with Standard User
Given the user is on the Sauce Demo login page
When the user enters 'standard_user' as username and 'secret_sauce' as password
And the user clicks on the login button
Then the user should be redirected to the inventory page

Scenario: Successful Login with Visual User
Given the user is on the Sauce Demo login page
When the user enters 'visual_user' as username and 'secret_sauce' as password
And the user clicks on the login button
Then the user should be redirected to the inventory page

Scenario: Unsuccessful Login with Invalid Username
Given the user is on the Sauce Demo login page
When the user enters 'invalid_user' as username and 'secret_sauce' as password
And the user clicks on the login button
Then the user should see an error message

Scenario: Unsuccessful Login with Invalid Password
Given the user is on the Sauce Demo login page
When the user enters 'standard_user' as username and 'invalid_password' as password
And the user clicks on the login button
Then the user should see an error message

Scenario: Unsuccessful Login with Empty Credentials
Given the user is on the Sauce Demo login page
When the user leaves the username and password fields empty
And the user clicks on the login button
Then the user should see an error message