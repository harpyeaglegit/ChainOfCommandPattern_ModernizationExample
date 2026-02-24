# Using the Chain Of Command Design Pattern Concepts to Perform Validation and Processing of Complex Data: Revisiting Legacy 2009 CodeProject Article Modernization to 2025 Architecture

A complete modernization and reinterpretation of a Chain of Responsibility example originally published on CodeProject in 2009.  
This updated 2025 edition preserves the educational value of the original article while introducing a fully redesigned architecture using modern C#, SOLID principles, async/await, and a clean multi-project structure.

---

# 📑 Table of Contents

- [Introduction](#introduction)
- [Background: The Classic Chain of Responsibility Pattern](#background-the-classic-chain-of-responsibility-pattern)
  - [The Intent of the Pattern](#the-intent-of-the-pattern)
- [The Legacy 2009 Implementation](#the-legacy-2009-implementation)
  - [What Worked Well in 2009](#what-worked-well-in-2009)
  - [Limitations of the Legacy Architecture](#limitations-of-the-legacy-architecture)
- [Requirements for a Modern Chain of Responsibility System](#requirements-for-a-modern-chain-of-responsibility-system)
- [Modern 2025 Architecture Overview](#modern-2025-architecture-overview)
  - [Multi-Project Solution Structure](#multi-project-solution-structure)
- [Core Interfaces and Abstractions](#core-interfaces-and-abstractions)
  - [IChainHandler\<T>](#ichainhandlert)
  - [IChainManager\<T>](#ichainmanagert)
  - [HandlerResult and ChainHandlerException](#handlerresult-and-chainhandlerexception)
- [Chain Manager Strategies](#chain-manager-strategies)
  - [StopOnFirstErrorChainManager](#stoponfirsterrorchainmanager)
  - [InvokeAllHandlersChainManager](#invokeallhandlerschainmanager)
- [Login Validation Chain (Modernized Example)](#login-validation-chain-modernized-example)
- [Transaction Processing Chain](#transaction-processing-chain)
- [Chain Construction via Factory Pattern](#chain-construction-via-factory-pattern)
- [Data Access Layer: Repository](#data-access-layer-repository)
- [Modern Benefits: Why the Pattern Still Matters in 2025](#modern-benefits-why-the-pattern-still-matters-in-2025)
- [Comparison: 2009 vs 2025](#comparison-2009-vs-2025)
- [Demonstration Application (WinForms UI)](#demonstration-application-winforms-ui)
- [Conclusion](#conclusion)

---

# Introduction

In 2009, a Chain of Command (Responsibility) demonstration was published on CodeProject to teach a clean, structured way of validating user input in sequential steps. The original example handled:

- Login validation  
- Bank account transactions  
- Sequential business rules  
- Handler-style validation logic  

However, software engineering has evolved dramatically since then.

### This 2025 modernization:

- Rewrites the architecture using **modern C#** (async/await, generics, interfaces)
- Implements **SOLID** and **clean architecture** principles
- Separates responsibilities into **four distinct projects**
- Introduces **strategy-based chain managers**
- Adds **diagnostics**, **repository pattern**, and **factory pattern**
- Completely removes UI coupling from business logic

The goal remains the same as in 2009:

👉 Teach and demonstrate the Chain of Command pattern through a clean, understandable, and extensible example.

But the implementation is modern, testable, scalable, and production-appropriate.

---

# Background: The Classic Chain of Responsibility Pattern

## The Pattern

The Chain Of Command Design pattern is well documented, and has been successfully used in many software solutions.

- Pattern involves a sequence of loosely coupled programming units, or handler objects.
- Objects are grouped together to form the links in a chain of handlers.
- Each handler performs its processing logic, then potentially passes the processing request onto the next link (i.e. handler) in the chain. 
- A client using the chain will only make one request for processing.  After this request, the chain handlers work to do the processing.

```
+-------------+     +-------------+     +-------------+
|  Handler 1  | --> |  Handler 2  | --> |  Handler 3  |
+-------------+     +-------------+     +-------------+
        |                   |                   |
        V                   V                   V
  (processes)        (processes)        (processes or
   request)            request           ends chain)
```

## Benefits of the Chain Of Command Design Pattern:

- Complex processing algorithms can be simplified by breaking down logical units of work, and placing each unit of work in a chain handler.
- Clients are de-coupled from the chain mechanism. Clients using the chain do not have to know specifics of handler processing logic, the structure of the links that make up the chain, nor the individual programming unit that will handle a request.
- Handlers are isolated processing units and are loosely coupled, meaning that one handler does not have knowledge of other handler logic.
- Chains can be dynamically constructed and modified to meet varying requirements.

## Notes on Traditional Implementation of the Pattern:
- Data is passed down the line from the starting handler, to the last.
- Some requests may not get handled by any handler in the chain (in case of errors, handling strategy, etc)
- Many handlers are implemented in a linked list fashion, where one handler which has not handled a request, chooses to invoke the next handler in the chain.

--- 

# The Legacy 2009 Implementation

The original CodeProject article presented a simple, effective solution to demonstrate the pattern using WinForms and synchronous C#.

## What Worked Well in 2009

- Clear educational example  
- Straightforward handler logic  
- Demonstrated sequential validation  
- Simple UI to show results  
- Easy for beginners to understand  

## Limitations of the Legacy Architecture

- **No async support** (synchronous only)  
- **Tight coupling** between UI and validation logic  
- **Difficult to test** individual handlers  
- **Global/static state leakage**  
- **No separation of concerns** (UI, business logic, and infrastructure mixed)  
- **No clear strategy for error handling**  
- **No standardized factory or repository**  

The modernization effort addresses each of these concerns.

---

# Requirements for a Modern Chain of Responsibility System

A modern design should:

- Use **interfaces** to define handlers and managers  
- Support **async/await**  
- Allow **multiple strategies** (stop on error vs run all)  
- Ensure **UI independence**  
- Support **unit testing**  
- Use DI-friendly architecture  
- Encapsulate business rules away from implementation details  
- Provide diagnostics for process visibility  

The solution presented here satisfies all of these goals.

---

# Modern 2025 Architecture Overview

The updated architecture uses four primary projects:

- **ChainOfCommandCore** — interfaces, exceptions, shared abstractions  
- **ChainOfCommandManagerImpl** — chain manager strategy implementations  
- **AppExampleCofCImpl** — domain rules, handlers, data access, chain factories  
- **AppCofCExampleWinForms** — simple demo UI

# Core Interfaces and Abstractions

## IChainHandler\<T>

Each handler implements:

```csharp
public interface IChainHandler<TRequest>
{
    Task<HandlerResult> ProcessAsync(TRequest requestData);
}
```

- Handlers are strongly typed

- Each performs one responsibility (SRP)

- Violations throw ChainHandlerException

## IChainManager<T>

Each Chain Manager implements:
```C#
public interface IChainManager<TRequest>
{
    void AppendHandler(IChainHandler<TRequest> handler);
    Task<HandlerResult> ProcessAsync(TRequest requestData);
}
```
- Managers pass the specfied data down the internal chain.
- Manager can have different strategies
    - Stop on the first handler that returns error condition
    - Allow all handlers to process the data, even though the overall result of execution is failure.
   
## HandlerResult and ChainHandlerException

- A Handler can return a HandlerResult.Failure to indicate a processing failure 
- A Handler can also throw a ChainHandlerException to indicate a processing failure, with an error message indicated in the exception.

# Chain Manager Strategies

A Chain Manager is defined by the interface, IChainManager<T>. Managers can be written for different strategies.
Examples used in the demonstration application include:

## StopOnFirstErrorChainManager

Stops pipeline execution as soon as the first handler fails (either by throwing exception or returning a failure result)
This manager is used in the demo application to process an account withdrawal, deposit transaction

## InvokeAllHandlersChainManager

Runs all handlers and aggregates the results — ideal for login validation scenarios.
This manager is used in the demo application to process a login (user) id, password verification.


# Login Validation Chain Example
The demo application login validation chain consists of a sequence of handlers managed by a InvokeAllHandlersChainManager.
In this scenario, every handler will be able to examine the login data and determine if it is valid according to the business rule it enforces.

```
+------------------------------+
|      Login Validation        |
+------------------------------+

[LoginIdZeroOrNegativeValidationHandler]
                |
                V
[LoginIdValidationHandler]
                |
                V
[LoginPasswordValidationHandler]
                |
                V
          (Login Success)

```



# Transaction Processing Chain
The demo application transaction processing chain consists of a sequence of handlers managed by a StopOnFirstErrorChainManager.
In this scenario, the first handler that indicates a failure will result in the chain processing being stopped with an error result returned. 

```
+--------------------------------------+
|     Transaction Processing Chain      |
+--------------------------------------+

[TransactionAccountNumberValidationHandler]
                     |
                     V
[TransactionAmountValidationHandler]
                     |
                     V
[TransactionTypeValidationHandler]
                     |
                     V
[TransactionUserIdAccountAssociationHandler]
                     |
                     V
[TransactionProcessHandler]
                     |
                     V
            (Transaction Complete)

```

# Chain Construction via Factory Pattern

Handlers are assembled using a dedicated factory as shown in the account validation chain construction:
```C#
public static IChainManager<TransactionData> CreateTransactionChain()
{
    var chain = new StopOnFirstErrorChainManager<TransactionData>();

    chain.AppendHandler(new TransactionAccountNumberValidationHandler());
    chain.AppendHandler(new TransactionAmountValidationHandler());
    chain.AppendHandler(new TransactionTypeValidationHandler());
    chain.AppendHandler(new TransactionUserIdAccountAssociationHandler());
    chain.AppendHandler(new TransactionProcessHandler());

    return chain;
}

```
Using factories:

- Standardizes chains
- Prevents inconsistent ordering
- Centralizes rules

# Data Access Layer: Repository

The updated example uses:

- IDataStore — repository abstraction

- InMemoryDataStore — sample data source

- DataAccess — application access to data (business logic) interacts with IDataStore, not the implementation.

This keeps domain logic independent of storage details.

# Modern Benefits: Why the Pattern Still Matters in 2025

The Chain of Responsibility pattern provides:

- Clean decomposition of business rules

- Easy handler insertion/removal

- High testability

- Reusable pipelines

- Natural fit for async workflows

- Perfect alignment with SOLID principles

Even in 2025, it remains a relevant and powerful pattern for validation, workflows, and processing pipelines.


# Comparison: 2009 vs 2025

| Category       | 2009 Version           | 2025 Version                     |
| -------------- | ---------------------- | -------------------------------- |
| Architecture   | Single project         | Multi-project clean architecture |
| Async Support  | None                   | Full async/await                 |
| Handler Design | Mixed responsibilities | Pure SRP handlers                |
| Chain Strategy | Hardcoded              | Pluggable strategies             |
| UI Coupling    | High                   | Zero                             |
| Data Access    | Hardcoded lists        | Repository pattern               |
| Extensibility  | Limited                | Unlimited                        |
| Documentation  | Basic article          | Full diagrams + article          |


# Demonstration Application (WinForms UI)

A simple UI demonstrates:

- Login validation

- Bank transaction processing

- Handler-by-handler diagnostics

It depends only on abstractions, not implementations — a key modern design principle.

# Conclusion

The original 2009 article offered a clear demonstration of the Chain of Responsibility pattern.
This 2025 modernization transforms it into a scalable, testable, and architecturally sound implementation aligned with modern C# software engineering standards.

By using:

- Proper separation of concerns

- SOLID principles

- Async/await

- Strategy pattern for chain management

- Repository pattern for data

- Factory pattern for handler assembly

The Chain of Command design pattern uses relatively simple, loosley coupled, isolated programming units (i.e. chain handlers) linked together to form a chain. The client makes one request to the chain for processing, and has no knowledge of internal chain structure. Chains can be dynamically allocated and modified.
Use this design pattern to break down and solve complicated data processing tasks, which will increase maintainability and flexibility, while reducing the complexity of software solutions.

