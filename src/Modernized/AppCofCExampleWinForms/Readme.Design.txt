Demonstration Project:

This project exists to simple demonstrate using a Factory to build and execute application specific chains of command / chain of responsibility,
and report user results.

This project is not an example of modern UI design or best practices.


*******************************************************
SOLID & Clean Architecture Principles Demonstrated
*******************************************************
S — Single Responsibility
	UI does UI; handlers do business rules; managers coordinate flow.

O — Open/Closed
	You can add/replace handlers without changing the UI.

L — Liskov Substitution
	Any chain manager strategy works transparently.

I — Interface Segregation
	UI depends only on IChainManager<T> and optionally IChainManagerDiagnostics.

D — Dependency Inversion
	UI does NOT depend on concrete handler classes.
