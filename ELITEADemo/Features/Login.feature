Feature: Login

  Scenario: Successful Login with Standard User
    Given I navigate to the Sauce Demo login page
    When I enter username "standard_user" and password "secret_sauce"
    And I click on the login button
    Then I should be redirected to the inventory page

  Scenario: Successful Login with Visual User
    Given I navigate to the Sauce Demo login page
    When I enter username "visual_user" and password "secret_sauce"
    And I click on the login button
    Then I should be redirected to the inventory page