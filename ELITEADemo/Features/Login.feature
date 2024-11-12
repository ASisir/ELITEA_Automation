Feature: Sauce Demo Login

Scenario: Successful Login with valid credentials
Given I am on the Sauce Demo login page
When I enter the username as 'standard_user' and password as 'secret_sauce'
And I click on the login button
Then I should be redirected to the inventory page

Scenario: Unsuccessful Login with invalid credentials
Given I am on the Sauce Demo login page
When I enter the username as 'invalid_user' and password as 'secret_sauce'
And I click on the login button
Then I should see an error message

Scenario: Successful Logout
Given I am logged in Sauce Demo site
When I click on the menu button
And I click on the logout link
Then I should be redirected to the login page

Scenario: Successful Login with another valid credentials
Given I am on the Sauce Demo login page
When I enter the username as 'visual_user' and password as 'secret_sauce'
And I click on the login button
Then I should be redirected to the inventory page

Scenario: Check the visibility of password
Given I am on the Sauce Demo login page
When I enter the password as 'secret_sauce'
Then I should be able to toggle the visibility of the password