FROM mcr.microsoft.com/dotnet/aspnet:6.0-focal AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
WORKDIR /src
COPY ["docker.api.csproj", "./"]
RUN dotnet restore "docker.api.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "docker.api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "docker.api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "docker.api.dll"]
