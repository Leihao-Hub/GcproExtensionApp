

@echo off
set ILMERGE_PATH="C:\Users\Operator\.nuget\packages\ilmerge\3.0.40\tools\net452\ILMerge.exe"

:: 验证ILMerge路径
if not exist %ILMERGE_PATH% (
    echo "错误: 找不到 ILMerge 工具，请检查路径设置."
    pause
    exit /b 1
)

:: 设置输出目录和文件名
set OUTPUT_DIR=%~dp0output
set OUTPUT_DLL=GcproExtensionLib.dll
set OUTPUT_PATH=%OUTPUT_DIR%\%OUTPUT_DLL%

:: 创建输出目录（如果不存在）
if not exist %OUTPUT_DIR% mkdir %OUTPUT_DIR%

:: 设置临时文件路径，临时文件用于保存合并的DLL文件名
set TEMP_DLL_LIST=%~dp0temp_dll_list.txt

:: 确保临时文件不存在
if exist %TEMP_DLL_LIST% del %TEMP_DLL_LIST%

:: 读取 dll_list.txt 并将文件名合并到一个行中，用空格分隔
for /F "tokens=* delims=" %%i in (dll_list.txt) do (
    echo %%i >> %TEMP_DLL_LIST%
)

:: 将临时文件中内容合并到一个行变量，并用空格分隔
setlocal enabledelayedexpansion
set INPUT_DLLS=
for /F "tokens=* delims=" %%i in (%TEMP_DLL_LIST%) do (
    set INPUT_DLLS=!INPUT_DLLS! %%i
)
endlocal & set INPUT_DLLS=%INPUT_DLLS%

:: 显示要执行的命令
echo Merging DLLs...
echo %ILMERGE_PATH% /allowDup /out:%OUTPUT_PATH% %INPUT_DLLS%

:: 运行 ILMerge 命令，并捕获输出和错误
%ILMERGE_PATH% /allowDup /out:%OUTPUT_PATH% %INPUT_DLLS%
if %ERRORLEVEL% neq 0 (
    echo "ILMerge 执行失败. 请检查上面的错误信息."
    pause
    exit /b 1
)

:: 检查生成的文件是否存在
if not exist %OUTPUT_PATH% (
    echo "Erroe: the merge file can't generated."
    pause
    exit /b 1
) else (
    echo "Merge sucessful: %OUTPUT_PATH%"
)

:: 删除临时文件
if exist %TEMP_DLL_LIST% del %TEMP_DLL_LIST%

:: 暂停，等待用户按任意键继续
pause



