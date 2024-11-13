Feature: Login Feature

Scenario 1: Successful Login with Valid Credentials

Scenario: Successful Login with Valid Credentials
Given User is on Login Page of Sauce Demo
When User enters valid Username and Password
And User clicks on Login Button
Then User should be redirected to the Home Page

Scenario 2: Unsuccessful Login with Invalid Credentials

Scenario: Unsuccessful Login with Invalid Credentials
Given User is on Login Page of Sauce Demo
When User enters invalid Username and Password
And User clicks on Login Button
Then User should see an error message

Scenario 3: Unsuccessful Login with Empty Username

Scenario: Unsuccessful Login with Empty Username
Given User is on Login Page of Sauce Demo
When User leaves Username field empty and enters valid Password
And User clicks on Login Button
Then User should see an error message

Scenario 4: Unsuccessful Login with Empty Password

Scenario: Unsuccessful Login with Empty Password
Given User is on Login Page of Sauce Demo
When User enters valid Username and leaves Password field empty
And User clicks on Login Button
Then User should see an error message

Scenario 5: Unsuccessful Login with Empty Username and Password

Scenario: Unsuccessful Login with Empty Username and Password
Given User is on Login Page of Sauce Demo
When User leaves both Username and Password fields empty
And User clicks on Login Button
Then User should see an error message