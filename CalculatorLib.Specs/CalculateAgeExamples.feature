Feature: CalculateAgeExamples
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the age of a person with a given birthdate

@mytag
Scenario Outline: Calculate age
	Given I have entered a <name>
	And I have also entered a <birthdate>
	When I press button Calculate age
	Then The result should be <age>

	Examples:
	| name  | birthdate    | age |
	| 'Ann' | '1998-06-30' | 26  |
	| 'Bob' | '2002-06-30' | 22  |
	| 'Joe' | '1992-06-30' | 32  |