Feature: CookieFarm
	In order to win cookie farm challenge
	As a player
	I want to know how many seconds I should spend

@mytag
Scenario: Get Time To Win
	Given I enter following values:
		| field                 | values |
		| Cookies To Buy A Farm | 500.0  |
		| Frequency             | 4.0    |
		| Cookies To Win        | 2000.0 |
	When I start playing the game
	Then I want to see total time '526.1904762' seconds
