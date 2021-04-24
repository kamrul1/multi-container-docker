#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MultiContainerDocker.Web/MultiContainerDocker.Web.csproj", "MultiContainerDocker.Web/"]
RUN dotnet restore "MultiContainerDocker.Web/MultiContainerDocker.Web.csproj"
COPY . .
WORKDIR "/src/MultiContainerDocker.Web"
RUN dotnet build "MultiContainerDocker.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MultiContainerDocker.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MultiContainerDocker.Web.dll"]