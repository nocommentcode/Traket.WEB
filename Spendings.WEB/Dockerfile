#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Spendings.WEB/Spendings.WEB.csproj", "Spendings.WEB/"]
RUN dotnet restore "Spendings.WEB/Spendings.WEB.csproj"
COPY . .
WORKDIR "/src/Spendings.WEB"
RUN dotnet build "Spendings.WEB.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Spendings.WEB.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Spendings.WEB.dll"]