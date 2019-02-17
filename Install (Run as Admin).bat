@echo off
md "C:\DifferentSLIAutoLoader"
xcopy %~dp0\DifferentSLIAutoLoader C:\DifferentSLIAutoLoader /s /y
SchTasks /Create /SC ONSTART  /TN "DifferentSLIAutoLoader" /TR C:\DifferentSLIAutoLoader\DifferentSLIAutoLoader.exe /ru system /F