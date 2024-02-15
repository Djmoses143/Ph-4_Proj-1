Feature: Login

A short summary of the feature

@mytag
Scenario: Successfull Login
	Given a user with valid username "Moses" and valid password "1234"
	When the LoginDetails method is called
	Then the result should be Login Success

Scenario: Unsuccessfull Login
	Given a user with invalid username "invalid_user" and invalid password "invalid"
	When the LoginDetails method is called
	Then the result should be Login Failed
