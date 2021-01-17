Feature: LoginUserFeature1

Scenario: Login User
	Given I input email <techie@email.com>
	And I input password <techie>
	When I send<login user request>
	Then the result should be <acces_token and status_code_ok>