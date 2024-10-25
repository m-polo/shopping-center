FROM mcr.microsoft.com/dotnet/sdk:7.0
WORKDIR /migrations
COPY . .

RUN dotnet tool install --version 7.0.18 --global dotnet-ef
ENV PATH="$PATH:/root/.dotnet/tools"

CMD dotnet ef database update --startup-project Sales.WebApi --project ./Gateways/EFCore.Repositories.csproj --context SalesContext -- --environment Production 
