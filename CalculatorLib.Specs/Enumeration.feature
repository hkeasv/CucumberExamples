Feature: Enumeration
	In order to be able to process an order
	As an office clerk at the company
	I want to be able to calculate the shipping fee

Scenario Outline: Calculate shipping fee
	Given the shipping method is <shippingMethod>
	When I press Calculate Shipping fee
	Then the result should be <shippingFee>

	Examples:
	| shippingMethod | shippingFee |
	| 'Standard'     | 20          |
	| 'Expedited'    | 40          |