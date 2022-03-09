dotnet publish -r browser-wasm -c Debug /p:TargetArchitecture=wasm /p:PlatformTarget=AnyCPU /p:MSBuildEnableWorkloadResolver=false /p:EmccExtraArgs="hello_callback.c --shell-file ../assets/shell.html --pre-js $env:EMSDK/upstream/emscripten/src/emscripten-source-map.min.js -gsource-map --source-map-base" --self-contained

python -m http.server -d bin/Debug/net6.0/browser-wasm/native