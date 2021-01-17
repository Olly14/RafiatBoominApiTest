Feature: LocationsFeature

Scenario: Get Locations
	Given I input route id is <empty>
	And I input second second parameter is <empty>
	When I send<Get all locations>
	Then the result should be <Ok>