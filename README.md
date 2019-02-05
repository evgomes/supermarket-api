# Supermarket API

Simple RESTful API built with ASP.NET Core 2.2 to show how to create RESTful services using a decoupled, maintainable architecture.

## Frameworks and Libraries
- [ASP.NET Core 2.2](https://docs.microsoft.com/pt-br/aspnet/core/?view=aspnetcore-2.2);
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/) (for data access);
- [Entity Framework In-Memory Provider](https://docs.microsoft.com/en-us/ef/core/miscellaneous/testing/in-memory) (for testing purposes);
- [AutoMapper](https://automapper.org/) (for mapping resources and models);

## How to Test

First, install [.NET Core 2.2](https://dotnet.microsoft.com/download/dotnet-core/2.2). Then, open the terminal or command prompt at the API root path (```/src/Supermarket.API/```) and run the following commands, in sequence:

```
dotnet restore
dotnet run
```

Navigate to ```http://localhost:5000/api/categories``` to check if the API is working. If you see a HTTPS security error, just add an exception to see the results.

To test all endpoints, you need to use a software such as [Postman](https://www.getpostman.com/).