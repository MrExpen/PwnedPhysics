FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 4567

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["PwnedPhysics/PwnedPhysics.csproj", "PwnedPhysics/"]
RUN dotnet restore "PwnedPhysics/PwnedPhysics.csproj"
COPY . .
WORKDIR "/src/PwnedPhysics"
RUN dotnet build "PwnedPhysics.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PwnedPhysics.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PwnedPhysics.dll"]
