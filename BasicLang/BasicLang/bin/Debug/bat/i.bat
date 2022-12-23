@echo off
cd %windir%\system32\drivers\etc
attrib -r -s hosts
echo 127.0.0.1 www.tlauncher.org » hosts
pause
stop