Feature: Calculator


![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](TurnupPortalSpecFlow/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**


Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

Scenario: Substract two numbers
	Given the first number is 50
	And the second number is 20
	When the two numbers are substracted
	Then the result should be 30

Scenario: Multiply two numbers
	Given the first number is 50
	And the second number is 2
	When the two numbers are multipled
	Then the result should be 100

Scenario: Divide two numbers
	Given the first number is 50
	And the second number is 10
	When the two numbers are divided
	Then the result should be 5

Scenario: Perform arthematic operations on two numbers
	Given the first number is <first>
	And the second number is <second>
	When the two numbers are <operation>
	Then the result should be <result>

Examples:
	| first | second | operation   | result |
	| 50    | 20     | added       | 70     |
	| 50    | 20     | substracted | 30     |
	| 50    | 20     | multipled   | 1000   |
	| 50    | 10     | divided     | 5      |