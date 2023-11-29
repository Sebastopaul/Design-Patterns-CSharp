FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["sl-app-tp-29112023.csproj", "./"]
RUN dotnet restore "sl-app-tp-29112023.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "sl-app-tp-29112023.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "sl-app-tp-29112023.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "sl-app-tp-29112023.dll"]
