Feature: Login

Scenario: Successful login with standard user
Given I navigate to the Sauce Demo login page
When I enter username 'standard_user' and password 'secret_sauce'
And I click on the login button
Then I should be redirected to the products page

Scenario: Successful login with visual user
Given I navigate to the Sauce Demo login page
When I enter username 'visual_user' and password 'secret_sauce'
And I click on the login button
Then I should be redirected to the products page

Scenario: Unsuccessful login with invalid username
Given I navigate to the Sauce Demo login page
When I enter username 'invalid_user' and password 'secret_sauce'
And I click on the login button
Then I should see an error message

Scenario: Unsuccessful login with invalid password
Given I navigate to the Sauce Demo login page
When I enter username 'standard_user' and password 'wrong_password'
And I click on the login button
Then I should see an error message

Scenario: Login button is disabled when username and password fields are empty
Given I navigate to the Sauce Demo login page
When I do not enter any username or password
Then the login button should be disabled