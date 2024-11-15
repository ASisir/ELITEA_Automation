Feature: Login

Scenario: Successful login with valid credentials
Given User is on the login page
When User enters valid username and password
And User clicks on the login button
Then User should be redirected to the home page

Scenario: Unsuccessful login with invalid username
Given User is on the login page
When User enters invalid username and valid password
And User clicks on the login button
Then User should see an error message

Scenario: Unsuccessful login with invalid password
Given User is on the login page
When User enters valid username and invalid password
And User clicks on the login button
Then User should see an error message

Scenario: Unsuccessful login with empty username and password
Given User is on the login page
When User leaves the username and password fields empty
And User clicks on the login button
Then User should see an error message

Scenario: Successful logout
Given User is logged in
When User clicks on the logout button
Then User should be redirected to the login page

Scenario: Successful login with valid credentials
    Given I am on the login page
    When I enter valid username 'standard_user' and password 'secret_sauce'
    And I click on the login button
    Then I should be redirected to the products page

  Scenario: Unsuccessful login with invalid credentials
    Given I am on the login page
    When I enter invalid username 'invalid_user' and password 'invalid_password'
    And I click on the login button
    Then I should see an error message 'Invalid username or password'