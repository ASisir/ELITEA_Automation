Feature: Login functionality

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