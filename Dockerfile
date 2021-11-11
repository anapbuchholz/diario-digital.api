  
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY . .
RUN dotnet restore "diario-digital.api/diario-digital.api.csproj"
COPY ./diario-digital.api ./diario-digital.api
WORKDIR "/src/diario-digital.api"
RUN dotnet build "diario-digital.api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "diario-digital.api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

RUN useradd -m myappuser
USER myappuser

CMD ASPNETCORE_URLS="http://*:$PORT" dotnet diario-digital.api.dll