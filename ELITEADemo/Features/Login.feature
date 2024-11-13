Feature: Login

Scenario: Successful login with standard user
Given I am on the login page
When I enter username as 'standard_user' and password as 'secret_sauce'
And I click on login button
Then I should be redirected to the products page

Scenario: Successful login with visual user
Given I am on the login page
When I enter username as 'visual_user' and password as 'secret_sauce'
And I click on login button
Then I should be redirected to the products page

Scenario: Unsuccessful login with invalid user
Given I am on the login page
When I enter username as 'invalid_user' and password as 'secret_sauce'
And I click on login button
Then I should see an error message

Scenario: Unsuccessful login with empty user
Given I am on the login page
When I enter username as '' and password as 'secret_sauce'
And I click on login button
Then I should see an error message

Scenario: Unsuccessful login with empty password
Given I am on the login page
When I enter username as 'standard_user' and password as ''
And I click on login button
Then I should see an error message