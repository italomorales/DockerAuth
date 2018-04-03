FROM microsoft/aspnetcore:2.0-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0-nanoserver-1709 AS build
WORKDIR /src
COPY BankU.Poc.sln ./
COPY BankU.Poc.Account.Api/BankU.Poc.Account.Api.csproj BankU.Poc.Account.Api/
RUN dotnet restore -nowarn:msb3202,nu1503
COPY . .
WORKDIR /src/BankU.Poc.Account.Api
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "BankU.Poc.Account.Api.dll"]
