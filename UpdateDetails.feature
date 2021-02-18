Feature: UpdateDetails
	To update firstname on the MyPersonalInfo page

@Scenario2
Given I navigate to website 
And i click on sign in button
And I enter an email address and password to login '<email>', '<password>' and sign in
When I select my personal info at the bottom of screen
Then i am able to clear the firstname and update the '<firstname>'
And I am able to enter '<current_password>' '<new_password>' and '<confirmation>'
Then i am able to save page updating the record

Examples: 
|      email       | password     | firstname |current_password|new_password|confirmation|
| aol@gmaail.comr  | Okocha1212@  | Jameson   |Okocha1212@     |Okocha1313@  |Okocha1313@|