@echo off
SET path=%~dp0
SchTasks /Create /SC ONSTART  /TN "DifferentSLIAutoLoader" /TR "%path%DifferentSLIAutoTools.exe /nogui" /ru system /F