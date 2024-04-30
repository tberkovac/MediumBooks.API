FROM mcr.microsoft.com/dotnet/sdk:8.0

WORKDIR /app

COPY . .

RUN dotnet build

EXPOSE 5001

CMD ["dotnet", "run", "--project", "MediumBooks.API", "--urls", "http://0.0.0.0:5001"]