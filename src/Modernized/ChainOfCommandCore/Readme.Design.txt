
******************************************************
Library: ChainOfCommandCore:
******************************************************

The ChainOfCommandCore library provides a flexible and extensible framework for implementing the Chain of Command / 
Chain of Responsibility design pattern for applications.

This library provides interfaces, type definitions, and exception classes involved in construction of chains of handlers to 
process requests or commands in a decoupled manner.



******************************************************
Modernization Features
******************************************************
(1) Full async/await support — all handler logic is asynchronous
(2) Strong generics for type-safe pipelines
(3) No framework dependencies — reusable across console, WinForms, WPF, ASP.NET, microservices, etc.
(4) Extensible manager strategies
(5) Improved diagnostics via optional exception collection


******************************************************
Asynchronous Support:
******************************************************
All handlers and chain managers use asynchronous patterns via async/await to provide multi-threaded, non-blocking operations.
This allows for improved performance and responsiveness in applications that require concurrent processing 
(e.g.: web servers, ASP.NET, UI applications, etc.)

******************************************************
SOLID Principles Applied:
******************************************************

- Single Responsibility Principle: 
	Introduces functionality of a chain of management 'handler', or link in the chain.
	Each handler is responsible for a single task, making it easier to maintain and extend.
	Each handler is not aware of any other handler in the chain, or how the chain is managed/implemented.

- Open/Closed Principle: 
	New handlers can be added without modifying existing code, allowing the system to grow and adapt to new requirements.
	Various ChainManager implementations can be constructed without modifying existing code:
		Conceptual examples of chain managers with different behaviors include:
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
	This library promotes the use of abstractions, allowing high-level modules to depend on low-level modules through interfaces.

