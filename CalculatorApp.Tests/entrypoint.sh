#!/bin/sh


# Test sonuçlarını dosyaya yaz
dotnet test > /app/logs/test_result.txt 2>&1

echo "Merhaba Dünya" > /app/dosya.txt

# Konteyneri açık tutmak için
tail -f /dev/null

