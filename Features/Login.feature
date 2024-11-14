Feature: Login to Sauce Demo

Scenario: Successful Login with Valid Credentials
Given User is at the Sauce Demo Login Page
When User enters valid Username and Password
And Clicks on the Login Button
Then User should be redirected to the Home Page

Scenario: Unsuccessful Login with Invalid Credentials
Given User is at the Sauce Demo Login Page
When User enters invalid Username and Password
And Clicks on the Login Button
Then User should see an error message

Scenario: Unsuccessful Login with Empty Username
Given User is at the Sauce Demo Login Page
When User leaves the Username field empty
And Clicks on the Login Button
Then User should see an error message

Scenario: Unsuccessful Login with Empty Password
Given User is at the Sauce Demo Login Page
When User leaves the Password field empty
And Clicks on the Login Button
Then User should see an error message

Scenario: Remember Credentials for Successful Login
Given User is at the Sauce Demo Login Page
When User enters valid Username and Password
And User selects the Remember Me option
And Clicks on the Login Button
Then User should be redirected to the Home Page
And User's credentials should be remembered for the next login