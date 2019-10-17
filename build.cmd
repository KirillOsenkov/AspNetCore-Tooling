@echo off
powershell -ExecutionPolicy ByPass -NoProfile -command "& """%~dp0eng\common\Build.ps1""" -restore -build -pack -binaryLog /p:DotNetUseShippingVersions=true /p:DebugType=embedded %*"
exit /b %ErrorLevel%
