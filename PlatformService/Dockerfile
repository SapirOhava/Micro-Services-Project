# the first thing is the image we want to pull down from docker hub
FROM mcr.microsoft.com/dotnet/sdk:7.0 as build-env  
WORKDIR /app
COPY *.csproj ./
RUN dotnet restore
COPY . ./
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=build-env /app/out .
EXPOSE 80
ENTRYPOINT ["dotnet", "PlatformService.dll"]
