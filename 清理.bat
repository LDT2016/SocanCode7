@echo off

set target=SocanCode

echo ������������

del %target%\*.txt
del %target%\*.pdb
del %target%\*.manifest
del %target%\*.application
del %target%\*.vshost.*

del %target%\Config\System.xml
del %target%\Config\History.xml


echo ���