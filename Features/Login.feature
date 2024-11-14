Feature: Login to Sauce Demo

Scenario: Successful Login with Valid Credentials
Given User is on the Login Page of Sauce Demo
When User enters valid Username and Password
And Clicks on the Login Button
Then User should be redirected to the Home Page

Scenario: Unsuccessful Login with Invalid Credentials
Given User is on the Login Page of Sauce Demo
When User enters invalid Username and Password
And Clicks on the Login Button
Then User should see an error message

Scenario: Unsuccessful Login with Empty Credentials
Given User is on the Login Page of Sauce Demo
When User leaves the Username and Password fields empty
And Clicks on the Login Button
Then User should see an error message

Scenario: Successful Logout from the Application
Given User is logged in to the Sauce Demo application
When User clicks on the Logout button
Then User should be redirected to the Login Page

Scenario: Remember Credentials for Future Logins
Given User is on the Login Page of Sauce Demo
When User enters valid Username and Password
And User checks the Remember Me checkbox
And Clicks on the Login Button
Then User's credentials should be remembered for future logins