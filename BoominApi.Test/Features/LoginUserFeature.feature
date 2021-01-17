Feature: LoginUserFeature

Scenario: Add two numbers
	Given I input email <techie@email.com>
	And I input password <techie>
	When I send <login_request>
	Then the result should be <access_token>