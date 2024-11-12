Feature: Login

Scenario: Successful login with standard user
Given I am on the Sauce Demo login page
When I enter 'standard_user' as username and 'secret_sauce' as password
And I click on the login button
Then I should be redirected to the inventory page

Scenario: Successful login with visual user
Given I am on the Sauce Demo login page
When I enter 'visual_user' as username and 'secret_sauce' as password
And I click on the login button
Then I should be redirected to the inventory page

Scenario: Unsuccessful login with incorrect password
Given I am on the Sauce Demo login page
When I enter 'standard_user' as username and 'incorrect_password' as password
And I click on the login button
Then I should see an error message

Scenario: Unsuccessful login with empty username
Given I am on the Sauce Demo login page
When I leave the username field empty and enter 'secret_sauce' as password
And I click on the login button
Then I should see an error message

Scenario: Unsuccessful login with empty password
Given I am on the Sauce Demo login page
When I enter 'standard_user' as username and leave the password field empty
And I click on the login button
Then I should see an error message