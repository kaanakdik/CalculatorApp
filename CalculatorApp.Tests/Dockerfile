FROM mcr.microsoft.com/dotnet/sdk:8.0

WORKDIR /app
COPY . .

CMD ["dotnet", "test", "--logger:trx;LogFileName=test_results.trx", "--results-directory=logs", "tee test_output.txt"]

# CMD dotnet test --no-build --logger "trx;LogFileName=test_results.trx" | tee test_output.txt