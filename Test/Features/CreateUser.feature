Feature: CreateUser

Create a user

@tag1
Scenario: [scenario CreteaUser.json] 
	Given [payload"CreteaUser.json"]  
	When [request]
	Then [validate]
