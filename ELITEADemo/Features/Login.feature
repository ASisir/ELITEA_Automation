Feature: Login to Sauce Demo

  Scenario: Valid Login
    Given I am on the Sauce Demo login page
    When I enter valid username 'standard_user' and password 'secret_sauce'
    And I click on the login button
    Then I should be redirected to the products page

  Scenario: Invalid Login
    Given I am on the Sauce Demo login page
    When I enter invalid username 'invalid_user' and password 'wrong_sauce'
    And I click on the login button
    Then I should see an error message

  Scenario: Empty Username
    Given I am on the Sauce Demo login page
    When I enter empty username and valid password 'secret_sauce'
    And I click on the login button
    Then I should see an error message regarding empty username

  Scenario: Empty Password
    Given I am on the Sauce Demo login page
    When I enter valid username 'standard_user' and empty password
    And I click on the login button
    Then I should see an error message regarding empty password

  Scenario: Logout
    Given I am logged in with username 'standard_user' and password 'secret_sauce'
    When I click on the logout button
    Then I should be redirected back to the login page