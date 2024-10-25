FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app
COPY . .

FROM build AS publish
RUN dotnet publish Sales.WebApi -c Release -o out

FROM base AS final
WORKDIR /app
COPY --from=publish /app/out .

ENTRYPOINT ["dotnet", "Sales.WebApi.dll"]
