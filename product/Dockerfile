FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /app
COPY *.csproj ./
COPY skopenet.crt /usr/local/share/ca-certificates/skopenet.crt
RUN chmod 644 /usr/local/share/ca-certificates/skopenet.crt && update-ca-certificates -v
RUN dotnet restore
COPY . ./
RUN dotnet publish -c Release -o /out

FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build /out .
ENTRYPOINT ["dotnet", "testwapi.dll"]