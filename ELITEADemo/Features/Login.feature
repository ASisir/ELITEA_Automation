Feature: Login

Scenario: Successful Login with standard_user
Given I navigate to the Sauce Demo login page
When I enter username "standard_user" and password "secret_sauce"
And I click on the login button
Then I should be redirected to the inventory page

Scenario: Successful Login with visual_user
Given I navigate to the Sauce Demo login page
When I enter username "visual_user" and password "secret_sauce"
And I click on the login button
Then I should be redirected to the inventory page