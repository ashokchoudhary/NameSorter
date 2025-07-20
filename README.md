# NameSorter
	
	The Goal: Name Sorter The Goal: Name Sorter Build a name sorter. Given a set of names, order that set first by last name, then by any given names the person may have. A name must have at least 1 given name and may have up to 3 given names. 

# Project Assumption
	
	Person name should have at least 2 word to classify full name which has Given Name and Last Name
	Empty blank case will be skiped
	
# Project Structure
	/NameSorter
		/NameSorter.App              // Main console app
			sorted-names-list.txt        // Generate output file
			unsorted-names-list.txt      // Input file
		/NameSorter.Tests            // Unit tests
		appveyor.yml                 // AppVeyor pipeline yml config

# Flow
	- Get file path
    - Read data from file
    - Sort data
    - Write data to output file