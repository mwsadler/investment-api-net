FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Investment.API/Investment.API.csproj", "Investment.API/"]
RUN dotnet restore "Investment.API/Investment.API.csproj"
COPY . .
WORKDIR "/src/Investment.API"
RUN dotnet build "Investment.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Investment.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Investment.API.dll"]
