Feature: Register

Test the register endpoint to ensure that user can successfully register


Scenario Outline: Register with invalid password
	Given I perform a POST request to the "/Authenticate/register" endpoint with Table
	| UserName | Email               | Password |
	| Tester1  | Tester1@example.com | Tester   |
	Then a "500" response is returned
	And I confirm the "message" field is "<ErrMsg>"

	Examples: 
	| ErrMsg                                                                                                                                |
	| User creation failed! Passwords must have at least one non alphanumeric character.  Passwords must have at least one digit ('0'-'9'). |

Scenario Outline: Register with No alphanumeric characters for password

	Given I perform a POST request to the "/Authenticate/register" endpoint with Table
	| UserName | Email               | Password  |
	| Tester1  | Tester1@example.com | Tester101 |
	Then a "500" response is returned
	And I confirm the "message" field is "<ErrMsg>"

	Examples: 
	| ErrMsg                                                                             |
	| User creation failed! Passwords must have at least one non alphanumeric character. |


Scenario Outline: Successfully register

	Given I perform a POST request to the "/Authenticate/register" endpoint with Table
	| UserName | Email               | Password   |
	| Tester1  | Tester1@example.com | Tester101. |
	Then a "200" response is returned
	And I confirm the "message" field is "<SuccessMsg>"
	Then I peform a POST request to the "/Authenticate/delete" endpoint to delete newly created user
	| UserName |
	| Tester1  |
	And I confirm the "message" field is "<DeleteSuccessMsg>"

	Examples: 
	| SuccessMsg                 | DeleteSuccessMsg           |
	| User created successfully! | User deleted successfully! |

Scenario Outline: Register Admin user with invalid password
	Given I perform a POST request to the "/Authenticate/register" endpoint with Table
	| UserName | Email               | Password |
	| Tester1  | Tester1@example.com | Tester   |
	Then a "500" response is returned
	And I confirm the "message" field is "<ErrMsg>"

	Examples: 
	| ErrMsg                                                         |
	| User creation failed! Please check user details and try again. |

Scenario Outline: Successfully register Admin user

	Given I perform a POST request to the "/Authenticate/register-admin" endpoint with Table
	| UserName     | Email                   | Password   |
	| Tester2Admin | TesterAdmin@example.com | Tester101. |
	Then a "200" response is returned
	And I confirm the "message" field is "<SuccessMsg>"
	Then I peform a POST request to the "/Authenticate/delete" endpoint to delete newly created user
	| UserName |
	| Tester1  |
	And I confirm the "message" field is "<DeleteSuccessMsg>"

	Examples: 
	| SuccessMsg                 | DeleteSuccessMsg           |
	| User created successfully! | User deleted successfully! |

Scenario Outline: Register with invalid email

	Given I perform a POST request to the "/Authenticate/register" endpoint with Table
	| UserName | Email              | Password  |
	| Tester1  | Tester1example.com | Tester101 |
	Then a "400" response is returned
