#

## Packages
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools

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