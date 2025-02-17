@echo off
setlocal

REM 设置 ILMerge 可执行文件的路径
set ILMERGE_PATH="C:\Users\Operator\.nuget\packages\ilmerge\3.0.40\tools\net452\ILMerge.exe"
echo ILMerge Path: %ILMERGE_PATH%

REM 自动设置项目路径为批处理文件所在目录
set PROJECT_PATH=%~dp0
echo Project Path: %PROJECT_PATH%

REM 设置输出目录和文件名
set OUTPUT_DIR=%PROJECT_PATH%output
echo Output Directory: %OUTPUT_DIR%

REM 设置输出文件的路径和名称
set OUTPUT_EXE=%OUTPUT_DIR%\GcproExtensionApp.exe
echo Output EXE: %OUTPUT_EXE%

REM 创建输出目录（如果不存在）
if not exist %OUTPUT_DIR% (
    echo Creating output directory: %OUTPUT_DIR%
    mkdir %OUTPUT_DIR%
)

REM 设置主 EXE 文件和依赖文件的绝对路径
set MAIN_EXE=%PROJECT_PATH%GcproExtensionApp.exe
set DEPENDENCIES=%PROJECT_PATH%GcproExtension.dll
set CONFIG_FILE=%PROJECT_PATH%appsettings.json

REM 检查主要 EXE 文件和依赖文件是否存在
if not exist %MAIN_EXE% (
    echo ERROR: Main EXE file %MAIN_EXE% not found!
    pause
    exit /b 1
)
if not exist %DEPENDENCIES% (
    echo ERROR: Dependency DLL file %DEPENDENCIES% not found!
    pause
    exit /b 1
)
if not exist %CONFIG_FILE% (
    echo ERROR: Configuration file %CONFIG_FILE% not found!
    pause
    exit /b 1
)

REM 输出文件路径
echo Merging files into: %OUTPUT_EXE%

REM 运行 ILMerge，并包括依赖 DLL
echo Running ILMerge...
%ILMERGE_PATH% /out:%OUTPUT_EXE% %MAIN_EXE% %DEPENDENCIES%

echo ILMerge exit code: %ERRORLEVEL%
if %ERRORLEVEL% neq 0 (
    echo ERROR: ILMerge failed with exit code %ERRORLEVEL%!
    pause
    exit /b %ERRORLEVEL%
)

REM 将配置文件复制到输出目录
echo Copying configuration file to output directory...
copy %CONFIG_FILE% %OUTPUT_DIR%

if %ERRORLEVEL% neq 0 (
    echo ERROR: Failed to copy configuration file!
    pause
    exit /b %ERRORLEVEL%
)

REM 删除输出目录中的PDB文件（如果存在）
if exist %OUTPUT_DIR%\GcproExtensionApp.pdb (
    echo Deleting PDB file %OUTPUT_DIR%\GcproExtensionApp.pdb...
    del %OUTPUT_DIR%\GcproExtensionApp.pdb
)

if exist %OUTPUT_DIR%\GcproExtension.pdb (
    echo Deleting PDB file %OUTPUT_DIR%\GcproExtension.pdb...
    del %OUTPUT_DIR%\GcproExtension.pdb
)

echo Merge and copy completed. Output is %OUTPUT_EXE%

endlocal
pause
