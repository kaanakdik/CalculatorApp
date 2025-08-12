FROM mcr.microsoft.com/dotnet/sdk:8.0

WORKDIR /app
COPY . .

# Testleri çalıştırıp sonucu logs/test_result.txt dosyasına yazan script koyalım
RUN mkdir -p /app/logs

COPY entrypoint.sh /app/entrypoint.sh
RUN chmod +x /app/entrypoint.sh

CMD ["/app/entrypoint.sh"]