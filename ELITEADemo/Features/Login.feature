Feature: Login

Scenario: Successful login with standard user
Given I am on the Sauce Demo login page
When I enter the username as "standard_user" and password as "secret_sauce"
And I click on the login button
Then I should be redirected to the inventory page

Scenario: Successful login with visual user
Given I am on the Sauce Demo login page
When I enter the username as "visual_user" and password as "secret_sauce"
And I click on the login button
Then I should be redirected to the inventory page

Scenario: Unsuccessful login with incorrect password
Given I am on the Sauce Demo login page
When I enter the username as "standard_user" and password as "incorrect_password"
And I click on the login button
Then I should see an error message

Scenario: Unsuccessful login with empty username
Given I am on the Sauce Demo login page
When I leave the username field empty and enter the password as "secret_sauce"
And I click on the login button
Then I should see an error message

Scenario: Unsuccessful login with empty password
Given I am on the Sauce Demo login page
When I enter the username as "standard_user" and leave the password field empty
And I click on the login button
Then I should see an error message