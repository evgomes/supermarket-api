# Supermarket API
<!-- ALL-CONTRIBUTORS-BADGE:START - Do not remove or modify this section -->
[![All Contributors](https://img.shields.io/badge/all_contributors-11-orange.svg?style=flat-square)](#contributors-)
<!-- ALL-CONTRIBUTORS-BADGE:END -->

Simple RESTful API built with ASP.NET Core 7 to show how to create RESTful services using a decoupled, maintainable architecture.

## A message from the author (July 5, 2023)

Hello, guys. It's been a while since I wrote the first version of this API and published the article on Medium and freeCodeCamp. My intention when I first wrote the API was to share knowledge on how to build applications in ASP.NET Core using patterns that I applied in my daily job and that I learned from many teaching sources.

I am not a professional writer, and I didn't have prior experience writing technical stuff, so I was happy to see the acceptance that my article received after its publication. I received lots of feedback from developers thanking me for the article and the knowledge that I shared, people asking me for guidance on how to develop features, people requesting articles about other programming concepts and technologies, and critiques from developers more experienced than me on things that I should improve.

Since then, I have been working on other interesting projects and concepts, and I try to share new things that I learn here on GitHub as frequently as I can. However, I haven't written any other articles due to personal life reasons and my work schedule.

I'm planning to start a tech blog soon. The acceptance I received from this article, the interactions here on GitHub, and people contacting me requesting more articles and asking for help with coding, in general, have motivated me to do it. I can't give you an exact date for this to happen, but I can tell you that the blog is already in development. For now, if you have any suggestions on topics you would like to read, both on .NET stuff or other technologies, please send a message to me, and I will consider your request. You can find my email in my GitHub profile bio.

For now, I'm updating this API and other projects I shared on GitHub to match the most recent versions of C# and .NET. If you want a reference to build full-stack .NET applications using a better architectural approach, and that uses modern tools and frameworks such as Docker and Blazor, please [refer to this other repository that I created](https://github.com/evgomes/net-core-notes).

Please let me know if you have any questions or suggestions regarding this project or any others that I have published. I'm always glad to help and to learn from you.

## Changes list

Many changes were made to the code presented at the tutorial published on [Medium](https://medium.com/free-code-camp/an-awesome-guide-on-how-to-build-restful-apis-with-asp-net-core-87b818123e28) and [freeCodeCamp](https://www.freecodecamp.org/news/an-awesome-guide-on-how-to-build-restful-apis-with-asp-net-core-87b818123e28/), to make the API code cleaner and to add functionalities that developers may find useful.

If you want to download the original code showed on the tutorial, download the [1.0.0](https://github.com/evgomes/supermarket-api/releases/tag/1.0.0) tag.

- 2.0.0 *[July 5, 2023]*
    - Updated .NET version to .NET 7.
    - Updated AutoMapper, Entity Framework Core, and Swashbuckle dependencies to match .NET 7.
    - Enabled implicit usings and nullable types.
    - Added global usings and removed implicit namespaces from the source code. 
    - Renamed the `UnitOfMeasurement` enum type to make it follow the official naming convention.
    - Removed `CategoryResponse` and `ProductReponse` types to use a generic `Response<T>` record type instead.
    - Changed API resources to use record types instead of classes, and to initialize values in an immutable way using `init`.
    - Added configuration to make all API routes lower-case.
    - Refactored services to include logging using the standar .NET logging provider and to make code cleaner. 

- 1.4.0 *[November 26, 2021]*
    - Updated .NET version to .NET 5 (see [#11](https://github.com/evgomes/supermarket-api/pull/11))
    - Updated AutoMapper, Entity Framework Core, and Swashbuckle dependencies to match .NET 5.
    - Created `BaseApiController` class to standardize routes and to automatically apply data annotations validation by using the `ApiController` attribute.
    - Refactored logic to seed database data and to apply entity type configuration for application models.

- 1.3.0 *[December 15, 2019]*
	- Updated ASP.NET Core version to 3.1, fixed issues related to InMemoryProvider, updated Swagger (see [#5](https://github.com/evgomes/supermarket-api/pull/5)).
	- Fixed paging calculation mistake, updated descriptions, updated "launchSettings.json" to open Swagger on running the application.

- 1.2.1 *[August 11, 2019]*
    - Changed `BaseResponse` to use generics as a way to simplify responses (see [#3](https://github.com/evgomes/supermarket-api/pull/3)).

- 1.2.0 *[July 15, 2019]*
    - Changed `/api/products` endpoint to allow pagination (see [#1](https://github.com/evgomes/supermarket-api/issues/1)).

- 1.1.0 *[June 18, 2019]*

  - Added Swagger documentation through [Swashbuckle](https://github.com/domaindrivendev/Swashbuckle).
  - Added cache through native [IMemoryCache](https://docs.microsoft.com/en-us/aspnet/core/performance/caching/memory?view=aspnetcore-2.2).
  - Changed products listing to allow filtering by category ID, to show how to perform specific queries with EF Core.
  - Changed ModelState validation to use *ApiController* attribute and *InvalidResponseFactory* in *Startup*.

- 1.0.0 *[February 4, 2019]*

  - First version of the example API, presented in the tutorial on [Medium](https://medium.com/free-code-camp/an-awesome-guide-on-how-to-build-restful-apis-with-asp-net-core-87b818123e28) and [freeCodeCamp](https://www.freecodecamp.org/news/an-awesome-guide-on-how-to-build-restful-apis-with-asp-net-core-87b818123e28/).

## Frameworks and Libraries
- [ASP.NET Core 7](https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-7.0).
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/) (for data access).
- [Entity Framework In-Memory Provider](https://docs.microsoft.com/en-us/ef/core/miscellaneous/testing/in-memory) (for testing purposes).
- [AutoMapper](https://automapper.org/) (for mapping resources and models).
- [Swashbuckle](https://github.com/domaindrivendev/Swashbuckle) (API documentation).

## How to Test

First, download and install the [.NET Core SDK](https://dotnet.microsoft.com/en-us/download). Then, open the terminal or command prompt at the API root path (```/src/Supermarket.API/```) and run the following commands, in sequence:

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
    <td align="center"><a href="https://github.com/mattbarry"><img src="https://avatars.githubusercontent.com/u/1567119?v=4?s=100" width="100px;" alt=""/><br /><sub><b>Matt Barry</b></sub></a><br /><a href="https://github.com/evgomes/supermarket-api/commits?author=mattbarry" title="Code">💻</a></td>
    <td align="center"><a href="https://hippiezhou.fun"><img src="https://avatars.githubusercontent.com/u/13598361?v=4?s=100" width="100px;" alt=""/><br /><sub><b>hippie</b></sub></a><br /><a href="https://github.com/evgomes/supermarket-api/commits?author=hippieZhou" title="Code">💻</a></td>
    <td align="center"><a href="https://github.com/NoobInTraining"><img src="https://avatars.githubusercontent.com/u/23185961?v=4?s=100" width="100px;" alt=""/><br /><sub><b>NoobInTraining</b></sub></a><br /><a href="https://github.com/evgomes/supermarket-api/commits?author=NoobInTraining" title="Code">💻</a></td>
    <td align="center"><a href="https://www.linkedin.com/in/mahmmoud-kinawy-7928b218a/"><img src="https://avatars.githubusercontent.com/u/57391128?v=4?s=100" width="100px;" alt=""/><br /><sub><b>Ma'hmmoud Kinawy</b></sub></a><br /><a href="https://github.com/evgomes/supermarket-api/commits?author=mahmmoudkinawy" title="Code">💻</a></td>
    <td align="center"><a href="https://www.linkedin.com/in/arazauk/"><img src="https://avatars.githubusercontent.com/u/22678337?v=4?s=100" width="100px;" alt=""/><br /><sub><b>Ahsan Raza</b></sub></a><br /><a href="https://github.com/evgomes/supermarket-api/pulls?q=is%3Apr+reviewed-by%3AAhsanRazaUK" title="Reviewed Pull Requests">👀</a></td>
    <td align="center"><a href="https://github.com/dundich"><img src="https://avatars.githubusercontent.com/u/1078713?v=4?s=100" width="100px;" alt=""/><br /><sub><b>dundich</b></sub></a><br /><a href="#ideas-dundich" title="Ideas, Planning, & Feedback">🤔</a></td>
    <td align="center"><a href="https://github.com/thedon-chris"><img src="https://avatars.githubusercontent.com/u/30728737?v=4?s=100" width="100px;" alt=""/><br /><sub><b>thedon_chris</b></sub></a><br /><a href="https://github.com/evgomes/supermarket-api/issues?q=author%3Athedon-chris" title="Bug reports">🐛</a></td>
  </tr>
  <tr>
    <td align="center"><a href="https://github.com/subhanisyed17"><img src="https://avatars.githubusercontent.com/u/46715997?v=4?s=100" width="100px;" alt=""/><br /><sub><b>subhanisyed17</b></sub></a><br /><a href="https://github.com/evgomes/supermarket-api/issues?q=author%3Asubhanisyed17" title="Bug reports">🐛</a></td>
    <td align="center"><a href="https://www.geekcafe.com"><img src="https://avatars.githubusercontent.com/u/3632968?v=4?s=100" width="100px;" alt=""/><br /><sub><b>Eric Wilson</b></sub></a><br /><a href="#question-eric-wilson" title="Answering Questions">💬</a></td>
    <td align="center"><a href="https://github.com/Pham-Tuan-Phat"><img src="https://avatars.githubusercontent.com/u/61822642?v=4?s=100" width="100px;" alt=""/><br /><sub><b>Phạm Tuấn Phát</b></sub></a><br /><a href="#ideas-Pham-Tuan-Phat" title="Ideas, Planning, & Feedback">🤔</a></td>
    <td align="center"><a href="https://github.com/miki-nis"><img src="https://avatars.githubusercontent.com/u/12809735?v=4?s=100" width="100px;" alt=""/><br /><sub><b>miki-nis</b></sub></a><br /><a href="https://github.com/evgomes/supermarket-api/issues?q=author%3Amiki-nis" title="Bug reports">🐛</a></td>
  </tr>
</table>

<!-- markdownlint-restore -->
<!-- prettier-ignore-end -->

<!-- ALL-CONTRIBUTORS-LIST:END -->

This project follows the [all-contributors](https://github.com/all-contributors/all-contributors) specification. Contributions of any kind welcome!
