dotnet publish -r browser-wasm -c Debug /p:TargetArchitecture=wasm /p:PlatformTarget=AnyCPU /p:MSBuildEnableWorkloadResolver=false /p:EmccExtraArgs="hello_native_library.c --shell-file ../assets/shell.html" --self-contained

python -m http.server -d bin/Debug/net6.0/browser-wasm/native