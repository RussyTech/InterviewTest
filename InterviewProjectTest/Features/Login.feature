Feature: Login

Test the Login endpoint to ensure that a user can login successfully

Scenario Outline: Login with invalid password
	
	Given I perform a POST request to the "/Authenticate/login" endpoint to login with Table 
	| UserName | Password            |
	| Tester2  | Tester101           |
	Then a "401" response is returned
	And I confirm the "title" field is "<TitleMsg>"

	Examples: 
	| TitleMsg     |  
	| Unauthorized |

Scenario: Login successfully

	Given I perform a POST request to the "/Authenticate/login" endpoint to login with Table 
	| UserName | Password            |
	| Tester2  | Tester101.          |
	Then a "200" response is returned