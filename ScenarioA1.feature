Feature: Verify that fields are auto populated after selecting

Scenario Outline: Amersi
	Given user is nagivate to checkup page and enter the "<text>" in practice filed
	And select the Amersi from dropdown
	When i select the OBGYN "<OBGYN>" for Speciality and click Compare now
	Then i should see all page and numbers should matches with overall section



	Examples: 
	| Test       | text         | OBGYN                                 |
	| ScenarioA1 | Amersi       | Obstetrician and Gynecologist (OBGYN) |

Scenario Outline: Prakash
	Given user is nagivate to checkup page and enter the "<text>" in practice filed
	And select the Prakash from dropdown
	When i select the NEURO "<NEURO>" for Speciality and click Compare now
	Then i should see all page and numbers should matches with overall section

	Examples: 
	| Test       | text         | NEURO       |
	| ScenarioA2 | Prakash Neal | Neurologist |