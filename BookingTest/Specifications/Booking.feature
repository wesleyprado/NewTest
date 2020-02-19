Feature: I as a user want to make a kick search at booking


Background: 
			Given I am in the Booking home page

@Booking
Scenario Outline: Search for a sauna hotel
	When I set up the data information
	And I filter the hotels with sauna
	Then  I check if the <hotels> are avaliable

Examples: 
			| hotels                |
			| Limerick Strand Hotel |
			| George Limerick Hotel |

@Booking
Scenario Outline: Search for a 5 stars hotel
	When I set up the data information
	And I filter the hotels with 5 stars
	Then  I check if the <hotels> are avaliable

Examples: 
			| hotels                |
			| The Savoy Hotel       |
			| George Limerick Hotel |