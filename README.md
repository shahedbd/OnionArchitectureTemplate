# Onion Architecture Template in ASP.NET Core MVC
The Onion Architecture term was coined by Jeffrey Palermo in 2008. This architecture provides a better way to build applications for better testability, maintainability, and dependability on the infrastructures like databases and services. 


## Advantages of Onion Architecture
- Maintainability
- Testability
- Loosely coupled
- Concrete implantation
- Domain entities are core and center part. It can have access to both the database and UI layers
- The internal layers never depend on the external layer

# Onion Architecture Layers
- Domain Entities Layer
- Repository Layer
- Service Layer
- UI (Web/Unit Test) Layer
