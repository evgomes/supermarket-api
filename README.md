# Supermarket API

Simple RESTful API built with ASP.NET Core 3.1 to show how to create RESTful services using a decoupled, maintainable architecture.

## Changes list

Some changes were made to the code presented at the tutorial published on [Medium](https://medium.com/free-code-camp/an-awesome-guide-on-how-to-build-restful-apis-with-asp-net-core-87b818123e28) and [freeCodeCamp](https://www.freecodecamp.org/news/an-awesome-guide-on-how-to-build-restful-apis-with-asp-net-core-87b818123e28/), to make the API code cleaner and to add functionalities that developers may find useful.

If you want to download the original code showed on the tutorial, download the [1.0.0](https://github.com/evgomes/supermarket-api/releases/tag/1.0.0) tag.

- 1.3.0 *[December 15, 2019]*
	- Updated ASP.NET Core version to 3.1, fixed issues related to InMemoryProvider, updated Swagger (see [#5](https://github.com/evgomes/supermarket-api/pull/5));
	- Fixed paging calculation mistake, updated descriptions, updated "launchSettings.json" to open Swagger on running the application.

- 1.2.1 *[August 11, 2019]*
    - Changed `BaseResponse` to use generics as a way to simplify responses (see [#3](https://github.com/evgomes/supermarket-api/pull/3)).

- 1.2.0 *[July 15, 2019]*
    - Changed `/api/products` endpoint to allow pagination (see [#1](https://github.com/evgomes/supermarket-api/issues/1)).

- 1.1.0 *[June 18, 2019]*

  - Added Swagger documentation through [Swashbuckle](https://github.com/domaindrivendev/Swashbuckle);
  - Added cache through native [IMemoryCache](https://docs.microsoft.com/en-us/aspnet/core/performance/caching/memory?view=aspnetcore-2.2);
  - Changed products listing to allow filtering by category ID, to show how to perform specific queries with EF Core;
  - Changed ModelState validation to use *ApiController* attribute and *InvalidResponseFactory* in *Startup*.

- 1.0.0 *[February 4, 2019]*

  - First version of the example API, presented in the tutorial on [Medium](https://medium.com/free-code-camp/an-awesome-guide-on-how-to-build-restful-apis-with-asp-net-core-87b818123e28) and [freeCodeCamp](https://www.freecodecamp.org/news/an-awesome-guide-on-how-to-build-restful-apis-with-asp-net-core-87b818123e28/).

## Frameworks and Libraries
- [ASP.NET Core 2.2](https://docs.microsoft.com/pt-br/aspnet/core/?view=aspnetcore-2.2);
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/) (for data access);
- [Entity Framework In-Memory Provider](https://docs.microsoft.com/en-us/ef/core/miscellaneous/testing/in-memory) (for testing purposes);
- [AutoMapper](https://automapper.org/) (for mapping resources and models);
- [Swashbuckle](https://github.com/domaindrivendev/Swashbuckle) (API documentation).

## How to Test

First, install [.NET Core 2.2](https://dotnet.microsoft.com/download/dotnet-core/2.2). Then, open the terminal or command prompt at the API root path (```/src/Supermarket.API/```) and run the following commands, in sequence:

```
dotnet restore
dotnet run
```

Navigate to ```https://localhost:5001/api/categories``` to check if the API is working. If you see a HTTPS security error, just add an exception to see the results.

Navigate to ```https://localhost:5001/swagger``` to check the API documentation.

![API Documentation](https://raw.githubusercontent.com/evgomes/supermarket-api/master/images/swagger.png)

To test all endpoints, you'll need to use a software such as [Postman](https://www.getpostman.com/).