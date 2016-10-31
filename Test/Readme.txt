这里的例子摘自Slua的例子，我用C#重新写了，然后用Cs2Lua转成lua执行。
另外加了一个单次执行的脚本，画一个Mandelbrot分形图。

这个例子工程同时演示了如何用C#写一个脚本工程，然后采用2种热更新方式，即动态加载DLL与lua脚本的方式。
Cs2Lua场景是演示启动场景。在GameRoot上挂了Game.cs脚本，用来初始化slua环境与动态加载c#的dll版本。
然后在MainCamera上挂了2个脚本，一个是启动时执行一次的，一个是带Tick执行的。在编辑模式可以选择是以lua脚本方式执行还是以C# dll方式执行。

工程：
1、CustomApi
这个工程演示实际unity3d工程要使用的外部dll，我们脚本类实现的接口在这个工程里定义，一般这个工程用来解耦脚本之间的依赖或
脚本与unity3d Assembly-CSharp.dll之间的依赖。

2、Cs2LuaScript
这个就是脚本工程，会被编译为dll放到unity3d的StreamingAssets目录，或者经cs2lua转换成lua脚本后放到Slua/Resources目录下。二种方式在功能上等价，
是热更新的2种实现方式，经由Cs2Lua工具，可以只写一次代码同时支持2种热更新。

3、TestUnity
例子unity3d工程，Scripts/Cs2Lua下的代码是用于加载dll与lua的代码。Game.cs是启动脚本。

4、Tools
编译好的Cs2Lua工具。

******
这个例子同时演示了一种可能，亦即基于unity3d的工程整体上采用插件架构，脚本用来实现具体插件，然后可以首先实现C#版本的插件（IOS下也可以，不拆分为
独立dll），然后在需要更新时动态变更为dll版本的插件(android mono情形)或lua脚本插件(il2cpp或ios mono aot情形)。这有可能提供一种性能与功能灵活性
的平衡，就是说每次更新一个大版本将获得最好的性能，然后逐渐更新后部分功能替换为脚本实现，性能会有所下降，到下一次大版本更新再提升到最佳性能。并
且也允许玩家一直不更新大版本，在性能稍差的情况下不影响游戏功能。