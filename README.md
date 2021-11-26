# Supermarket API
<!-- ALL-CONTRIBUTORS-BADGE:START - Do not remove or modify this section -->
[![All Contributors](https://img.shields.io/badge/all_contributors-1-orange.svg?style=flat-square)](#contributors-)
<!-- ALL-CONTRIBUTORS-BADGE:END -->

Simple RESTful API built with ASP.NET 5 to show how to create RESTful services using a decoupled, maintainable architecture.

## Changes list

Some changes were made to the code presented at the tutorial published on [Medium](https://medium.com/free-code-camp/an-awesome-guide-on-how-to-build-restful-apis-with-asp-net-core-87b818123e28) and [freeCodeCamp](https://www.freecodecamp.org/news/an-awesome-guide-on-how-to-build-restful-apis-with-asp-net-core-87b818123e28/), to make the API code cleaner and to add functionalities that developers may find useful.

If you want to download the original code showed on the tutorial, download the [1.0.0](https://github.com/evgomes/supermarket-api/releases/tag/1.0.0) tag.

- 1.4.0 *[November 26, 2021]*
    - Updated .NET version to .NET 5 (see [#11](https://github.com/evgomes/supermarket-api/pull/11))
    - Updated AutoMapper, Entity Framework Core, and Swashbuckle dependencies to match .NET 5.
    - Created `BaseApiController` class to standardize routes and to automatically apply data annotations validation by using the `ApiController` attribute.
    - Refactored logic to seed database data and to apply entity type configuration for application models.

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
- [ASP.NET 5](https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-5.0);
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/) (for data access);
- [Entity Framework In-Memory Provider](https://docs.microsoft.com/en-us/ef/core/miscellaneous/testing/in-memory) (for testing purposes);
- [AutoMapper](https://automapper.org/) (for mapping resources and models);
- [Swashbuckle](https://github.com/domaindrivendev/Swashbuckle) (API documentation).

## How to Test

First, install [.NET 5](https://dotnet.microsoft.com/download/dotnet/5.0). Then, open the terminal or command prompt at the API root path (```/src/Supermarket.API/```) and run the following commands, in sequence:

```
dotnet restore
dotnet run
```

Navigate to ```https://localhost:5001/api/categories``` to check if the API is working. If you see a HTTPS security error, just add an exception to see the results.

Navigate to ```https://localhost:5001/swagger``` to check the API documentation and to test all API endpoints.

![API Documentation](https://raw.githubusercontent.com/evgomes/supermarket-api/master/images/swagger.png)

## Contributors ✨

Thanks goes to these wonderful people ([emoji key](https://allcontributors.org/docs/en/emoji-key)):

<!-- ALL-CONTRIBUTORS-LIST:START - Do not remove or modify this section -->
<!-- prettier-ignore-start -->
<!-- markdownlint-disable -->
<table>
  <tr>
    <td align="center"><a href="https://www.linkedin.com/in/mahmmoud-kinawy-7928b218a/"><img src="https://avatars.githubusercontent.com/u/57391128?v=4?s=100" width="100px;" alt=""/><br /><sub><b>Ma'hmmoud Kinawy</b></sub></a><br /><a href="https://github.com/evgomes/supermarket-api/commits?author=mahmmoudkinawy" title="Code">💻</a></td>
  </tr>
</table>

<!-- markdownlint-restore -->
<!-- prettier-ignore-end -->

<!-- ALL-CONTRIBUTORS-LIST:END -->

This project follows the [all-contributors](https://github.com/all-contributors/all-contributors) specification. Contributions of any kind welcome!