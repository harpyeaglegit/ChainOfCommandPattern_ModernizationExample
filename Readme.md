# Chain-of-Command Modernization Project (2025 Edition)

![.NET](https://img.shields.io/badge/.NET-9.0-blue)
![License: GPL v3](https://img.shields.io/badge/License-GPLv3-green)
![Platform: WinForms](https://img.shields.io/badge/Platform-WinForms-lightgrey)
![Architecture: SOLID](https://img.shields.io/badge/Architecture-SOLID-orange)


## 🧰 Tech Stack

### **Languages**
![C#](https://img.shields.io/badge/Language-C%23-239120.svg?logo=c-sharp&logoColor=white)

### **Frameworks & Runtime**
![.NET 9](https://img.shields.io/badge/.NET-9.0-512BD4?logo=dotnet&logoColor=white)
![WinForms](https://img.shields.io/badge/WinForms-512BD4?logo=windows&logoColor=white)

### **Architecture & Patterns**
![SOLID](https://img.shields.io/badge/Architecture-SOLID-orange)
![Chain of Responsibility](https://img.shields.io/badge/Pattern-Chain_of_Responsibility-blue)
![Factory Pattern](https://img.shields.io/badge/Pattern-Factory-green)
![Repository Pattern](https://img.shields.io/badge/Pattern-Repository-lightgrey)
![Singleton Pattern](https://img.shields.io/badge/Pattern-Singleton-9cf)
![Strategy Pattern](https://img.shields.io/badge/Pattern-Strategy-yellow)

### **UI / Client**
![WinForms](https://img.shields.io/badge/UI-WinForms-0078D6?logo=windows&logoColor=white)

### **Development Tools**
![Visual Studio](https://img.shields.io/badge/IDE-Visual_Studio-7733FF?logo=visual-studio&logoColor=white)
![Git](https://img.shields.io/badge/Version_Control-Git-F05032?logo=git&logoColor=white)
![GitHub](https://img.shields.io/badge/Hosted_on-GitHub-181717?logo=github&logoColor=white)

### **Documentation**
![Markdown](https://img.shields.io/badge/Docs-Markdown-000000?logo=markdown)


This repository is a complete modernization of a Chain-of-Command (Responsibility) demonstration project originally written in 2009 using C# and WinForms. The original article and example code were posted on CodeProject.com It has been fully refactored into a modern, clean, SOLID, async, multi-project architecture that demonstrates:

- Modern Chain-of-Command Design Pattern (clean, scalable implementation)
- Repository Design Pattern (Data access abstraction)
- Factory Design Pattern
- Singleton Design Pattern
- Multi-project architecture with clear separation of concerns
- Strategy-based chain manager implementations
- async/await-first handler design
- UI-agnostic business logic
- Professional project documentation and diagrams

# 📑 Table of Contents
- [Project Overview](#project-overview)
- [Demonstration Application](#demonstration-application)
- [Business Rules](#business-rules)
  - [Login Authorization Rules](#login-authorization-rules)
  - [Account Transaction Rules](#account-transaction-rules)
- [SOLID Principles Demonstrated](#solid-principles-demonstrated)
- [Before / After Modernization](#before--after-modernization)
- [Running the Demo](#running-the-demo)
- [License](#license)
- [Thanks](#thanks)


The solution is composed of four projects:

- ChainOfCommandCore        : Interfaces, exceptions, HandlerResult
- ChainOfCommandManagerImpl : Strategy based chain manager implementations
- AppExampleCofCImpl        : Contains domain-specific handlers and business rules for login and bank transactions
- AppCofCExampleWinForms    : WinForms UI demonstrating usage of the chain classes

This repository is both:
1. A modernization case study  
2. A professional architectural demonstration showing modern design concepts

---

# 🚀 Modernized Article

The complete, fully rewritten 2025 modernization paper (based on the original 2009 CodeProject article) is located under:

📄 **`/docs/Modernized-ChainOfResponsibility-2025.md`**

This article includes:

- Full pattern explanation  
- Architecture evolution (2009 → 2025)  
- Modern diagrams  
- Handler flowcharts  
- SOLID principles  
- Updated code samples 

---

# 📚 Project Overview

## ✔ ChainOfCommandCore
Defines the foundational abstractions for the chain system:

- `IChainHandler<T>`  
- `IChainManager<T>`  
- `IChainManagerDiagnostics`  
- `HandlerResult`  
- `ChainHandlerException`

Contains **no business logic** and **no external dependencies**.

---

## ✔ ChainOfCommandManagerImpl
Provides concrete, strategy-based chain managers:

### **StopOnFirstErrorChainManager<T>**  
Stops execution immediately when a handler fails.

### **InvokeAllHandlersChainManager<T>**  
Executes all handlers and aggregates exceptions + results.

### Features
- Async handler execution  
- Ordered handler lists  
- Exception aggregation  
- Diagnostics reporting  

Depends only on: **ChainOfCommandCore**

---

## ✔ Application Example Library: AppExampleCofCImpl
Contains demonstration application business logic and data access:

### Login Handlers
- LoginIdZeroOrNegativeValidationHandler  
- LoginIdValidationHandler  
- LoginPasswordValidationHandler  

### Transaction Handlers
- TransactionAccountNumberValidationHandler  
- TransactionTypeValidationHandler  
- TransactionAmountValidationHandler  
- TransactionUserIdAccountAssociationHandler  
- TransactionProcessHandler  

### Data Access
- `IDataStore` (repository abstraction)  
- `InMemoryDataStore` (sample data store implementation)  
- `DataAccess` (Singleton for data access)  

### Chain Construction
- `ChainManagerFactory` builds all application-specific chains.

Contains **no UI code** and can be consumed from any front end (WinForms, WPF, MAUI, Blazor, ASP.NET).

---

## ✔ Demonstration Project AppCofCExampleWinForms
A lightweight WinForms UI demonstrating:

- How to construct chain managers via the factory  
- How to pass strongly typed request models (LoginData, AccountTransactionData)  
- Interpreting a `HandlerResult`  
- How to report chain diagnostics (handler exceptions and results)  

All business logic lives in dependency library, **AppExampleCofCImpl**.  

The UI depends **only** on interfaces.

## ✔ Demonstration Application
The demonstration application is a simplified version of a banking application that requires a valid login. When the login is approved, the user can then process a withdrawal or deposit transaction.
The login and transaction is handled by two separate, dedicated chains, eaching containing muliple handlers (links) to implement business logic.

## ✔ Business Rules 

### Login Authorization Rules:
	
- (1) The login authorization will allow all handlers to examine login data, and contribute validation exceptions list. 
- (2) An integer login id must not be less than or equal to zero
- (3) The integer login id must be found in the data store.
- (4) The password string must match that found in the data store for the login id.

### Account Transaction Rules:
- (1) The transaction process should STOP on the first handler that reports a data error.
- (2) A transaction 'account number' must be found in the data store
- (3) A transaction 'type' must be either a 'D' character for deposit, or a 'W' character for withdrawal.
- (4) A transaction 'amount' must be a positive value.
- (5) After all validations are successfully completed, the transaction should be applied to the account.

Valid Data Set

| Login ID | Password | Account Number |
|------|--------------|--------------|
|1000|password0|9990|
|1001|password1|9991|
|1002|password2|9992|


---

# 🧬 SOLID Principles Demonstrated

### **S — Single Responsibility**
Each handler performs exactly one validation or processing step.

### **O — Open/Closed**
Add new handlers without modifying existing ones.

### **L — Liskov Substitution**
Any chain manager strategy can be swapped transparently.

### **I — Interface Segregation**
Minimal interfaces (`IChainHandler<T>`, `IDataStore`) keep dependencies tight.

### **D — Dependency Inversion**
UI depends on abstractions (factory + interfaces), not concrete handlers.

---

# 🔄 Before / After Modernization Summary

| Area | 2009 Version | 2025 Version |
|------|--------------|--------------|
| Project Structure | Single WinForms project | Multi-project, layered solution |
| Chain Behavior | Mixed flag toggles | Strategy pattern (clean subclasses) |
| Async Support | None | Full async/await |
| Handler Design | Mixed responsibilities | Pure, single-purpose handlers |
| UI Coupling | Tight | Fully decoupled |
| Data Access | Hard-coded lists | Repository pattern |
| Diagnostics | None | Detailed per-handler diagnostics |
| Documentation | Small article | Full modern documentation set |

---

# 🖥 Running the Demo

1. Open the solution in **Visual Studio 2022 or later**  
2. Set **AppCofCExampleWinForms** as the startup project  
3. Press **F5**  
4. Enter login credentials (valid and invalid cases)  
5. After valid login success, submit transactions (invalid, valid) to test validation steps  
6. View handler-level diagnostics in the output panel  

---

# 📂 Documentation and Diagrams

All detailed documentation on the Chain-of-Command pattern resides in: /docs

# 📜 License
This project is licensed under the terms of the GNU General Public License v3.0.

---

# 🙏 Thanks

This repository serves as a modernization retrospective and a professional architectural demonstration of the Chain-of-Responsibility pattern using clean C# design.

It is suitable for:

- Learning the chain of command pattern as well as several other patterns.
- Demonstrating architecture for a modern application  
- UI-agnostic validation pipeline design  

Enjoy exploring this modern C# implementation of Chain-of-Command!

