FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["src/gateways/API.Gateway/API.Gateway.csproj", "src/gateways/API.Gateway/"]
RUN dotnet restore "src/gateways/API.Gateway/API.Gateway.csproj"
COPY . .
WORKDIR "/src/src/gateways/API.Gateway"
RUN dotnet build "API.Gateway.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "API.Gateway.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "API.Gateway.dll"]
