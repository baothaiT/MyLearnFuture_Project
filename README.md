#

## Packages
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools

dotnet add package MediatR --version 11.1.0
dotnet add package MediatR.Extensions.Microsoft.DependencyInjection --version 11.1.0
dotnet add package MediatR.CommandQuery.EntityFrameworkCore --version 11.0.750

## Commands EF
dotnet tool install --global dotnet-ef

dotnet ef migrations add init
dotnet ef database update




## Architecture

MyLearnFuture.API
MyLearnFuture.Application
MyLearnFuture.Contract
MyLearnFuture.Domain
MyLearnFuture.Infrastructure
MyLearnFuture.Persistence