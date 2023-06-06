Feature: Search

As a user of KL
	I want to search for items
	


Scenario: [Items Search]
	Given I navigate to the website "https://cms.demo.katalon.com/"
	When I add four random items to my cart
	And I view my cart
	When I search for lowest price items
	And I am able to remove the lowest price item from my cart
	Then I am able to verify three items in my cart

