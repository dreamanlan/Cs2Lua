rem working directory
set workdir=%~dp0

cd %workdir%
del /s/f/q dsl\*.dsl
del /s/f/q dsl\*.txt
del /s/f/q dsl\*.js
Cs2Dsl -enableinherit -enablelinq -refbypath ..\..\dep\UnityEngine.dll -src test_js.cs
..\..\Generator\JsGenerator\bin\Debug\JsGenerator dsl


