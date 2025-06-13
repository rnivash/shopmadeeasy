FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app
COPY ./website/*.csproj ./
RUN dotnet restore
COPY ./website/ ./
RUN dotnet publish -c Release -o /out

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build-env /out ./
ENTRYPOINT ["dotnet", "website.dll"]