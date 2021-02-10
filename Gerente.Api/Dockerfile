#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["Gerente.Api/Gerente.Api.csproj", "Gerente.Api/"]
RUN dotnet restore "Gerente.Api/Gerente.Api.csproj"
COPY . .
WORKDIR "/src/Gerente.Api"
RUN dotnet build "Gerente.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Gerente.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Gerente.Api.dll"]