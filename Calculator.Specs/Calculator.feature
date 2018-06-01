Feature: Calculator
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the result of math calculations

Scenario: Add two numbers
	Given I have entered 50 into the calculator
		And I have also entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

Scenario: Multiply two numbers
	Given I have entered 5 into the calculator
		And I have also entered 2 into the calculator
	When I press multiply
	Then the result should be 10 on the screen

Scenario: Subtract two numbers
	Given I have entered 5 into the calculator
		And I have also entered 2 into the calculator
	When I press subtract
	Then the result should be 3 on the screen

Scenario Outline: divide two numbers
	Given I have entered <firstNumber> into the calculator
		And I have also entered <secondNumber> into the calculator
	When I press divide
	Then the result should be <result> on the screen

	Examples:
	| firstNumber | secondNumber | result |
	| 10          | 2            | 5      |
	| 70          | 7            | 10     |