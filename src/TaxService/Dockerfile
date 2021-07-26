FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/TaxService/TaxService.csproj", "src/TaxService/"]
COPY ["src/TaxService.Data/TaxService.Data.csproj", "src/TaxService.Data/"]
COPY ["src/TaxService.Domain/TaxService.Domain.csproj", "src/TaxService.Domain/"]
COPY ["src/TaxService.Application/TaxService.Application.csproj", "src/TaxService.Application/"]
RUN dotnet restore "src/TaxService/TaxService.csproj"
COPY . .
WORKDIR "/src/src/TaxService"
RUN dotnet build "TaxService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TaxService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TaxService.dll"]