FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app
COPY ./product/*.csproj ./
RUN dotnet restore
COPY ./product/ ./
RUN dotnet publish -c Release -o /out

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /out .
ENTRYPOINT ["dotnet", "product.dll"]