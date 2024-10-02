Feature: DataTable
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the age of a person with a given birthdate

Scenario: Calculate age
	Given I have entered the following person data
	| Name | BirthDate  |
	| Ann  | 1998-06-30 |
	When I press Calculate age
	Then The result should be 26 years