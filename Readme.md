# Shopping center

Shopping center is an example of API following Clean Architecture principles. 

It includes everything you need, including:

- [.NET Core Minimal API](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/minimal-apis?view=aspnetcore-7.0) for the frontend
- [Entity Framework](https://learn.microsoft.com/es-es/ef/) as ORM
- [Swagger](https://swagger.io) for API documentation
- [PostgreSQL](https://www.postgresql.org/) as database
- [Docker](https://www.docker.com/) for containerization
- [Clean Architecture](https://www.typescriptlang.org/) for solution architecture


## Using this template

Clone the repository:

```sh
git clone https://github.com/m-polo/shopping-center.git
```

Start everything with docker:

```sh
docker build
```

## What's inside?

It includes the following folder structure:

### Folder Structure

- Business Rules:
    - BusinessObjects: DTOs, domain entities, enums, interfaces.
    - UseCases: Interactors to handle requests for every use case.

- Frameworks and Drivers
    - UIs: Minimal API configuration and endpoints.
- Interface Adapters:
    - Contollers: Controllers implementations.
    - Gateways: ORM definition.
    - Presenters: Presenters implementations.
    - IoC: Grouped dependency injections.


### Build

To build solution, run the following command:

```sh
dotnet build
```

Or build shopping-center solution manually using Vs.

### Migrations

To apply migrations to database, run the following command:

```sh
dotnet ef database update --startup-project Sales.WebApi --project ./Gateways/EFCore.Repositories.csproj --context SalesContext
```

To add migrations, run the following command:

```sh
dotnet ef migrations add <migrationName> --startup-project Sales.WebApi --project ./Gateways/EFCore.Repositories.csproj --context SalesContext
```

### Start

To start API, run the following command:

```sh
dotnet run -p Sales.WebApi
```

Or set Sales.WebApi as startup project from VS and run it.

### Build and run API docker image

To containerize the app, run the following commands:

```sh
docker build -f Sales.WebApi/Dockerfile -t shopping-center-api .
docker run -p 5000:80 --name shopping-center-api shopping-center-api
 ```

 Using docker compose:

 ```sh
docker compose up --build
 ```