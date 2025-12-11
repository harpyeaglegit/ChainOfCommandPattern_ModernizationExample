
************************************************
Library: ChainOfCommandManagerImpl:
************************************************

The ChainOfCommandManagerImpl library provides concrete implementations of chain of command / chain of responsibility classes
that utilize the interfaces and types defined in the ChainOfCommandCore library.

These implementations offer various strategies for managing and executing chains of handlers to process requests or commands.
************************************************

************************************************
Asynchronous and Synchronous Support:
************************************************
All IChainManager and IChainHandler implementations in this library support asynchronous

************************************************
SOLID Principles Applied:
************************************************
(1) Single Responsibility Principle: 
	Each ChainManager implementation is responsible for a specific strategy of managing the chain of handlers.
	For example, the StopOnFirstErrorChainManager<T> is solely responsible for stopping the chain execution upon encountering the first error.

(2) Open/Closed Principle: 
	New ChainManager implementations can be added without modifying existing code, allowing the system to grow and adapt to new requirements.
	For instance, if a new strategy for handling chains is needed, a new ChainManager class can be created without altering existing implementations.
	Example: InvokeAllHandlersChainManager<T> has been implemented to invoke all handlers regardless of errors.
			 StopOnFirstErrorChainManager<T> stops execution on the first error encountered.

(3) Liskov Substitution Principle: 
	All ChainManager implementations can be substituted with one another as they adhere to the same IChainManager<T> interface, ensuring consistent behavior across different strategies.

(4) Interface Segregation Principle: 
	The library defines clear and specific interfaces for different ChainManager behaviors, allowing clients to depend only on the methods they use.
	For example, diagnostic functionalities are separated into the IChainManagerDiagnostics interface.

(5) Dependency Inversion Principle: 
	The library promotes the use of abstractions by depending on interfaces defined in the ChainOfCommandCore library, allowing high-level modules to remain decoupled from low-level implementations.