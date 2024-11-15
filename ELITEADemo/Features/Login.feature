Feature: Login

Scenario: Successful login with standard user
Given I navigate to the login page
When I enter username "standard_user" and password "secret_sauce"
And I click on the login button
Then I should be redirected to the products page

Scenario: Successful login with visual user
Given I navigate to the login page
When I enter username "visual_user" and password "secret_sauce"
And I click on the login button
Then I should be redirected to the products page

Scenario: Login attempt with invalid username
Given I navigate to the login page
When I enter username "invalid_user" and password "secret_sauce"
And I click on the login button
Then I should see an error message

Scenario: Login attempt with invalid password
Given I navigate to the login page
When I enter username "standard_user" and password "wrong_password"
And I click on the login button
Then I should see an error message

Scenario: Login attempt without entering credentials
Given I navigate to the login page
When I do not enter any credentials and click on the login button
Then I should see an error message