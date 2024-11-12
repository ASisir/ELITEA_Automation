Feature: Login

Scenario: Login with valid standard user credentials
Given I am on the Sauce demo login page
When I enter "standard_user" as username and "secret_sauce" as password
And I click on the login button
Then I should be redirected to the inventory page

Scenario: Login with valid visual user credentials
Given I am on the Sauce demo login page
When I enter "visual_user" as username and "secret_sauce" as password
And I click on the login button
Then I should be redirected to the inventory page

Scenario: Login with invalid credentials
Given I am on the Sauce demo login page
When I enter "invalid_user" as username and "invalid_password" as password
And I click on the login button
Then I should see an error message

Scenario: Login with empty credentials
Given I am on the Sauce demo login page
When I leave the username and password fields empty
And I click on the login button
Then I should see an error message

Scenario: Logout from the application
Given I am logged in to the Sauce demo application
When I click on the logout button
Then I should be redirected to the login page