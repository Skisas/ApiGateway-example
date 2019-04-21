FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["src/services/Deliveries/Deliveries.csproj", "src/services/Deliveries/"]
RUN dotnet restore "src/services/Deliveries/Deliveries.csproj"
COPY . .
WORKDIR "/src/src/services/Deliveries"
RUN dotnet build "Deliveries.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Deliveries.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Deliveries.dll"]
