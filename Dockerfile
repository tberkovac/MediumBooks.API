FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /app

COPY . .

RUN dotnet build

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final

WORKDIR /app

COPY --from=build /app .

EXPOSE 5001

CMD ["dotnet", "./MediumBooks.API/bin/Debug/net8.0/MediumBooks.API.dll", "--urls", "http://0.0.0.0:5001"]