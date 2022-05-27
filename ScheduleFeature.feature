Feature: Feature

A short summary of the feature

Scenario Outline: Validate header text for teacher schedule
	Given user in a schedule page
	When user choose t<teacher> in dropdown list
	And click on submitbutton
	Then schedule will be viewed for this teacher and header will contain <headerteacher>

	Examples: 
	| teacher | headerteacher |
	| Романенко Наталія Вікторівна | Романенко Наталія Вікторівна |

	Scenario Outline: Validate header text for group schedule
	Given user in a schedule page
	When user choose g<groupname> in dropdown list
	And click on submitbutton
	Then schedule will be viewed for this group and header will contain <headergroupname>

	Examples: 
	| groupname | headergroupname |
	| 32 (302) | 32 (302) |

	Scenario Outline: Validate header text for semester schedule
	Given user in a schedule page
	When user choose s<semester> in dropdown list
	And click on submitbutton
	Then schedule will be viewed for this semester and header will contain <headersemester>

	Examples: 
	| semester | headersemester |
	| 1 2021- 2022 | 1 2021- 2022 |