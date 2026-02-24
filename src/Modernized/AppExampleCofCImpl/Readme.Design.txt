
*************************************************
Library AppExampleCofCImpl:
*************************************************

This library provides concrete implementations of application-specific chain of command / chain of responsibility handlers.
Key design points: 

	(1) Library code only, without any UI dependencies, allows the library to be used by various type of UI interface apps. (e.g. Blazor, Maui, WPF)

	(2) Data Management:
		This library contains the data management layer (in real applications, this would most likely be a separate library)
		Every class outside of the data access class has no knowledge of how or where the data comes from.
		In this simple example, the data is a small, in-memory data store. 
		Real life data access could include: SQL server access, XML, CSV, Excel spreadsheets, text files, or any other type of store.
	
	(3) Design Pattern: (for DataManagement) : Repository
		The DataManagement/Interfaces/IDataStore.cs defines the interface for any data access class.
		The InMemoryDataStore.cs class implements a concrete in memory data store for the application.

	(4) Design Pattern : Factory
			- ChainOfCommand/Factory/ChainManagerFactory.cs implements the standard factory pattern, 
					and is responsible for  build the application specific chains.
				- Each chain contructed implements of enforces the business rules of the application.

	(5) Handlers - the Links in the chain - Reference ChainOfCommand/Handlers
			- 2 groups of links are used to form 2 separate application chains
				(a) Login Validation
				(b) Account transaction validation and processing
			- Each handler handles enforcing or implementing a portion of the business rules
		