# ASP.NET Core Template

A ready-to-use template for ASP.NET Core with repositories, services, models mapping, DI and StyleCop warnings fixed.

## Build status

[![Build Status](https://nikolayit.visualstudio.com/KrasiPool/_apis/build/status/NikolayIT.ASP.NET-Core-Template?branchName=master)](https://nikolayit.visualstudio.com/KrasiPool/_build/latest?definitionId=15&branchName=master)

## Authors

- [Nikolay Kostov](https://github.com/NikolayIT)
- [Vladislav Karamfilov](https://github.com/vladislav-karamfilov)
- [Stoyan Shopov](https://github.com/StoyanShopov)

## Package Installation

You can install this template using [NuGet](https://www.nuget.org/packages/KrasiPool):

```powershell
dotnet new -i KrasiPool
```

```powershell
dotnet new aspnet-core -n YourProjectName
```

## Pack this Template

```powershell
dotnet pack .\nuget.csproj
```

## Project Overview

![Dependencies Graph](https://user-images.githubusercontent.com/25417032/97107966-0e5fc500-16d3-11eb-9b9c-c73012ff97ac.png)
![image](https://user-images.githubusercontent.com/25417032/97108063-9fcf3700-16d3-11eb-8225-32eac21c4542.png)

### Common

**KrasiPool.Common** contains common things for the project solution. For example:

- [GlobalConstants.cs](https://github.com/NikolayIT/ASP.NET-Core-Template/blob/master/src/KrasiPool.Common/GlobalConstants.cs).

### Data

This solution folder contains three subfolders:

- KrasiPool.Data.Common
- KrasiPool.Data.Models
- KrasiPool.Data

#### KrasiPool.Data.Common

[KrasiPool.Data.Common.Models](https://github.com/NikolayIT/ASP.NET-Core-Template/tree/master/src/Data/KrasiPool.Data.Common/Models) provides abstract generics classes and interfaces, which holds information about our entities. For example when the object is Created, Modified, Deleted or IsDeleted. It contains a property for the primary key as well.

[KrasiPool.Data.Common.Repositories](https://github.com/NikolayIT/ASP.NET-Core-Template/tree/master/src/Data/KrasiPool.Data.Common/Repositories) provides two interfaces IDeletableEntityRepository and IRepository, which are part of the **repository pattern**.

#### KrasiPool.Data.Models

[KrasiPool.Data.Models](https://github.com/NikolayIT/ASP.NET-Core-Template/tree/master/src/Data/KrasiPool.Data.Models) contains ApplicationUser and ApplicationRole classes, which inherits IdentityRole and IdentityUsers.

#### KrasiPool.Data

[KrasiPool.Data](https://github.com/NikolayIT/ASP.NET-Core-Template/tree/master/src/Data/KrasiPool.Data) contains DbContext, Migrations and Configuraitons for the EF Core.There is Seeding and Repository functionality as well.

### Services

This solution folder contains four subfolders:

- KrasiPool.Services.Data
- KrasiPool.Services.Mapping
- KrasiPool.Services.Messaging
- KrasiPool.Services

#### KrasiPool.Services.Data

[KrasiPool.Services.Data](https://github.com/NikolayIT/ASP.NET-Core-Template/tree/master/src/Services/KrasiPool.Services.Data) wil contains service layer logic.

#### KrasiPool.Services.Mapping

[KrasiPool.Services.Mapping](https://github.com/NikolayIT/ASP.NET-Core-Template/tree/master/src/Services/KrasiPool.Services.Mapping) provides simplified functionlity for auto mapping. For example:

```csharp
using Blog.Data.Models;
using Blog.Services.Mapping;

public class TagViewModel : IMapFrom<Tag>
{
    public int Id { get; set; }

    public string Name { get; set; }
}
```

Or if you have something specific:

```csharp
using System;

using AutoMapper;
using Blog.Data.Models;
using Blog.Services.Mapping;

public class IndexPostViewModel : IMapFrom<Post>, IHaveCustomMappings
{
    public int Id { get; set; }

    public string Title { get; set; }

    public string Author { get; set; }

    public string ImageUrl { get; set; }

    public DateTime CreatedOn { get; set; }

    public void CreateMappings(IProfileExpression configuration)
    {
        configuration.CreateMap<Post, IndexPostViewModel>()
            .ForMember(
                source => source.Author,
                destination => destination.MapFrom(member => member.ApplicationUser.UserName));
    }
}

```

#### KrasiPool.Services.Messaging

[KrasiPool.Services.Messaging](https://github.com/NikolayIT/ASP.NET-Core-Template/tree/master/src/Services/KrasiPool.Services.Messaging) a ready to use integration with [SendGrid](https://sendgrid.com/).

#### KrasiPool.Services

[KrasiPool.Services](https://github.com/NikolayIT/ASP.NET-Core-Template/tree/master/src/Services/KrasiPool.Services)

### Tests

This solution folder contains three subfolders:

- KrasiPool.Services.Data.Tests
- KrasiPool.Web.Tests
- Sandbox

#### KrasiPool.Services.Data.Tests

[KrasiPool.Services.Data.Tests](https://github.com/NikolayIT/ASP.NET-Core-Template/tree/master/src/Tests/KrasiPool.Services.Data.Tests) holds unit tests for our service layer with ready setted up xUnit.

#### KrasiPool.Web.Tests

[KrasiPool.Web.Tests](https://github.com/NikolayIT/ASP.NET-Core-Template/tree/master/src/Tests/KrasiPool.Web.Tests) setted up Selenuim tests.

#### Sandbox

[Sandbox](https://github.com/NikolayIT/ASP.NET-Core-Template/tree/master/src/Tests/Sandbox) can be used to test your logic.

### Web

This solution folder contains three subfolders:

- KrasiPool.Web.Infrastructure
- KrasiPool.Web.ViewModels
- KrasiPool.Web

#### KrasiPool.Web.Infrastructure

[KrasiPool.Web.Infrastructure](https://github.com/NikolayIT/ASP.NET-Core-Template/tree/master/src/Web/KrasiPool.Web.Infrastructure) contains functionality like Middlewares and Filters.

#### KrasiPool.Web.ViewModels

[KrasiPool.Web.ViewModels](https://github.com/NikolayIT/ASP.NET-Core-Template/tree/master/src/Web/KrasiPool.Web.ViewModels) contains objects, which will be mapped from/to our entities and used in the front-end/back-end.

#### KrasiPool.Web

[KrasiPool.Web](https://github.com/NikolayIT/ASP.NET-Core-Template/tree/master/src/Web/KrasiPool.Web) self explanatory.

## Support

If you are having problems, please let us know by [raising a new issue](https://github.com/NikolayIT/ASP.NET-Core-Template/issues).

## Example Projects

- <https://github.com/NikolayIT/PressCenters.com>
- <https://github.com/NikolayIT/nikolay.it>

## License

This project is licensed with the [MIT license](LICENSE).
