# Stage 1
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /build
COPY LoadBalancerTesting/LoadBalancerTesting.csproj LoadBalancerTesting/

RUN dotnet restore LoadBalancerTesting/LoadBalancerTesting.csproj
COPY . .

RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app
# Stage 2
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "LoadBalancerTesting.dll"]