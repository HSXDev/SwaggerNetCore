
FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY swaggernetcore/swaggerNetcore.csproj ./swaggernetcore/
WORKDIR /app/swaggernetcore
RUN dotnet restore

# copy and publish app and libraries
WORKDIR /app/
COPY swaggernetcore/. ./swaggernetcore/
WORKDIR /app/swaggernetcore
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/runtime:2.2 AS runtime
WORKDIR /app
COPY --from=build /app/swaggernetcore/out ./
ENTRYPOINT ["dotnet", "swaggernetcore.dll"]