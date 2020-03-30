Feature: Men landing page
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Scenario: A site visitor in the men landing page clicks the logo A
	Given I navigate to the men page
	When I click the logo
	Then the page should be displayed

Scenario: A site visitor in the women landing page clicks the logo A
	Given I navigate to the women page
	When I click the logo
	Then the page should be displayed
