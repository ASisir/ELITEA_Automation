Feature: Login

Scenario: Valid Login
Given I am on the login page of Sauce Demo
When I enter 'standard_user' as username and 'secret_sauce' as password
And I click on the login button
Then I should be redirected to the home page

Scenario: Invalid Login
Given I am on the login page of Sauce Demo
When I enter 'invalid_user' as username and 'secret_sauce' as password
And I click on the login button
Then I should see an error message

Scenario: Empty Username
Given I am on the login page of Sauce Demo
When I leave the username field empty and enter 'secret_sauce' as password
And I click on the login button
Then I should see an error message

Scenario: Empty Password
Given I am on the login page of Sauce Demo
When I enter 'standard_user' as username and leave the password field empty
And I click on the login button
Then I should see an error message

Scenario: Empty Username and Password
Given I am on the login page of Sauce Demo
When I leave the username and password fields empty
And I click on the login button
Then I should see an error message