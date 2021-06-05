# syntax=docker/dockerfile:1
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
COPY Cinnabarlab.sln /src/
COPY Cinnabarlab.Api/*.csproj /src/Cinnabarlab.Api/
COPY Cinnabarlab.Data/*.csproj /src/Cinnabarlab.Data/
COPY Cinnabarlab.Infrastructure/*.csproj /src/Cinnabarlab.Infrastructure/
COPY Cinnabarlab.Plugins/*.csproj /src/Cinnabarlab.Plugins/
COPY Cinnabarlab.Plugins.Training/*.csproj /src/Cinnabarlab.Plugins.Training/
COPY Cinnabarlab.Plugins.Blog/*.csproj /src/Cinnabarlab.Plugins.Blog/

WORKDIR /src
RUN dotnet restore
COPY . .

WORKDIR /src/Cinnabarlab.Data
RUN dotnet build -c Release -o /app

WORKDIR /src/Cinnabarlab.Infrastructure
RUN dotnet build -c Release -o /app

WORKDIR /src/Cinnabarlab.Plugins
RUN dotnet build -c Release -o /app

WORKDIR /src/Cinnabarlab.Plugins.Training
RUN dotnet build -c Release -o /app

WORKDIR /src/Cinnabarlab.Plugins.Blog
RUN dotnet build -c Release -o /app

WORKDIR /src/Cinnabarlab.Api
RUN dotnet build -c Release -o /app

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:5.0
COPY --from=build-env /app /
ENTRYPOINT ["dotnet", "/Cinnabarlab.Api.dll"]