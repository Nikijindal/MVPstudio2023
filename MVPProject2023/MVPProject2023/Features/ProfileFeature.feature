Feature: ProfileFeature

As a Mars QA portal admin
I would like to add profile details such as languages,skills,education and certifications records
So that I am able to see the details on profile page

@tag1
Scenario: Register on Mars QA website with valid details
	Given I navigate to home page of Mars QA portal
	When I enter all fields on registration page 
	Then The user should be registered successfully

	Scenario Outline: Create profile record with valid details
	Given I logged into Mars QA portal successfully with valid credentials
	When I navigate to profile page
	And I create language,skills,education and certification record
	And select availability,hours and earn target
	Then The record should be created successfully

	Scenario Outline: Edit existing profile record with valid details
	Given I logged into Mars QA portal successfully with valid credentials
	When I navigate to profile page
	And I update existing '<language>','<level>' on existing language record
	Then the record should have updated '<language>','<level>' successfully 

	Examples: 
	| language | level            |
	| Hindi    | Native/Bilingual |
	| French   | Basic            |
	| Spanish  | Conversational   |

	Scenario Outline: Delete exisiting profile record with valid credentials
	Given I logged into Mars QA portal successfully with valid credentials
	When I navigate to profile page
	And I delete existing record on existing language record page
	Then the record should be deleted successfully