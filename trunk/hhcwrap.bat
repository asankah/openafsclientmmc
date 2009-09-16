REM Wraps the HTML Help Complier (hhc) since hhc gives a 1 errorlevel on success instead of zero
REM
REM Take notice that the if errorlevel construct matches that errorlevel and anything above it.
REM See http://support.microsoft.com/kb/69576
%1 %2
if ERRORLEVEL 1 if not ERRORLEVEL 2 exit /B 0
exit /B 1