FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ORM.App.csproj", "ORM.App/"]
RUN dotnet restore "ORM.App/ORM.App.csproj"
COPY . .
RUN dotnet publish "ORM.App.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "ORM.App.dll"]
