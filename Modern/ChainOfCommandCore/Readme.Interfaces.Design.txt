The ChainOfCommandCore library provides a flexible and extensible framework for implementing the Chain of Command / Chain of Responsibility design pattern in your applications.

SOLID Principles:
- Single Responsibility Principle: 
	Each handler is responsible for a single task, making it easier to maintain and extend.
	Each handler is not aware of any other handler in the chain, or how the chain is managed/implemented.

- Open/Closed Principle: 
	New handlers can be added without modifying existing code, allowing the system to grow and adapt to new requirements.
	Various ChainManager implementations can be constructed without modifying existing code:
		Examples of chain managers with different behaviors include:
				StopOnFirstErrorChainManager<T>
				ContinueOnErrorChainManager<T>	
				FirstHandlerWinsChainManager<T>	
				ParallelChainManager<T>
				AsyncChainManager<T>
				LoggingDecoratorChainManager<T>

- Liskov Substitution Principle: 
	Handlers can be substituted with other handlers that adhere to the same interface, ensuring consistent behavior.

- Interface Segregation Principle: 
	This library defines clear, specific interfaces for handlers, allowing clients to depend only on the methods they use.
	Example: The IChainManagerDiagnostics provides for diagnostic functionality without burdening the core chain management interfaces.

- Dependency Inversion Principle: 
	The library promotes the use of abstractions, allowing high-level modules to depend on low-level modules through interfaces.


