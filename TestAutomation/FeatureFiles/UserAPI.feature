Feature: UserData
	In order to get the user data from API
	As a developer
	I want to verify the API

@API
Scenario Outline: Check GET User content

@API
Scenario: Verify response
Given Create URL segment for <id> with GET method
When Execute API
And Deserialize the user api content
Then returned status code will be <statusCode>
And response should return valid <userId> , <Title>, <Body>

Examples: 
| userId | id | statusCode | Title                  | Body                                                                                                 |
| 10     | 98 | OK        | laboriosam dolor voluptates | doloremque ex facilis sit sint culpa\//nsoluta assumenda eligendi non ut eius\//nsequi ducimus vel quasi\/nveritatis est dolores |