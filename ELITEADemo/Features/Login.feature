Feature: Login

Scenario: Login with valid standard user credentials
Given I am on the Sauce Demo login page
When I enter 'standard_user' as username and 'secret_sauce' as password
And I click on the login button
Then I should be redirected to the products page

Scenario: Login with valid visual user credentials
Given I am on the Sauce Demo login page
When I enter 'visual_user' as username and 'secret_sauce' as password
And I click on the login button
Then I should be redirected to the products page

Scenario: Login with invalid credentials
Given I am on the Sauce Demo login page
When I enter 'invalid_user' as username and 'invalid_password' as password
And I click on the login button
Then I should see an error message

Scenario: Login with empty username
Given I am on the Sauce Demo login page
When I leave the username field empty and enter 'secret_sauce' as password
And I click on the login button
Then I should see an error message

Scenario: Login with empty password
Given I am on the Sauce Demo login page
When I enter 'standard_user' as username and leave the password field empty
And I click on the login button
Then I should see an error message