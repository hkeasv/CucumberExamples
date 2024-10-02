Feature: DataTableWithMultipleObjects
    In order to avoid silly mistakes
    As a math idiot
    I want to be told the age of a person with a given birthdate

Scenario: Calculate age of first person
    Given I have entered the following list of person data
    | Name | BirthDate  |
    | Ann  | 1998-06-30 |
    | Joe  | 2001-06-30 |
    When I press Calculate age of the first person
    Then The result should be 26 years for the first person  