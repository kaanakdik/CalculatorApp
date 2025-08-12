#!/bin/sh
# Test sonuçlarını dosyaya yaz
dotnet test > /app/logs/test_result.txt 2>&1

# Konteyneri açık tutmak için
tail -f /dev/null
