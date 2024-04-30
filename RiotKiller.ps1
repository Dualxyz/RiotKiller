@(Get-Process | Where-Object { $_.ProcessName -like "*League*" -or $_.ProcessName -like "*Riot*" } | Select-Object -ExpandProperty Id) | ForEach-Object { taskkill /PID $_ /F }
