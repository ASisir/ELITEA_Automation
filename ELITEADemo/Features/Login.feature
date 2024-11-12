Feature: Login

Scenario: Successful login with standard user
Given I am on the Sauce Demo login page
When I enter username as 'standard_user' and password as 'secret_sauce'
And I click on the login button
Then I should be redirected to the inventory page

Scenario: Successful login with visual user
Given I am on the Sauce Demo login page
When I enter username as 'visual_user' and password as 'secret_sauce'
And I click on the login button
Then I should be redirected to the inventory page

Scenario: Unsuccessful login with incorrect password
Given I am on the Sauce Demo login page
When I enter username as 'standard_user' and password as 'incorrect_password'
And I click on the login button
Then I should see an error message

Scenario: Unsuccessful login with incorrect username
Given I am on the Sauce Demo login page
When I enter username as 'incorrect_user' and password as 'secret_sauce'
And I click on the login button
Then I should see an error message

Scenario: Unsuccessful login with empty credentials
Given I am on the Sauce Demo login page
When I do not enter username and password
And I click on the login button
Then I should see an error message