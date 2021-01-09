# Cs2Lua
CSharp代码转lua，适用于使用lua实现热更新而又想有一个强类型检查的语言的场合



## 【命令行】

    Cs2Lua [-out dir] [-ext fileext] [-enableinherit] [-enablelinq] [-outputresult] [-noautorequire] [-luacomponentbystring] [-usearraygetset] [-enabletranslationcheck] [-d macro] [-u macro] [-externpath path] [-ignorepath path] [-refbyname dllname alias] [-refbypath dllpath alias] [-systemdllpath dllpath] [-src] csfile|csprojfile

其中:

    fileext = 生成的lua脚本文件扩展名，对unity3d和slua应该是txt，对普通lua则为lua。

    macro = 宏定义，会影响被转化的c#代码里的#if/#elif/#else/#endif语句的结果。

    dllname = 以名字（Assembly Name）提供的被引用的外部dotnet DLL，cs2lua尝试从名字获取这些DLL的路径（一般只有dotnet系统提供的DLL才可以这么用）。

    dllpath = 以文件全路径提供的被引用的外部dotnet DLL。

    alias = 外部dll顶层名空间别名，默认为global, 别名在c#代码里由'extern alias 名字;'语句使用。
    
    enableinherit = 此选项指明是否允许继承。

    outputresult = 此选项指明是否在控制台输出最终转化的结果（合并为单一文件样式）。

    src = 此选项仅用在refbyname/refbypath选项未指明alias参数的情形，此时需要此选项在csfile|csprojfile前明确表明后面的参数是输入文件。
    
Cs2Lua的输出主要包括：

    1、对应c#代码的转换出的lua代码，每个c#顶层类对应一个lua文件。

    2、所有名字空间的定义lua文件，此文件被1中文件引用，输出文件为cs2lua_namespaces.lua/txt。

    3、Cs2Lua依赖的lualib文件lualib.lua，输出文件名为cs2lua_lualib.lua/txt。

    4、在c#代码里使用Cs2Lua.Require明确指明要依赖的lualib文件，这些文件需要自己放到Cs2Lua.exe所在目录的子目录lualib里，之后自动拷到输出目录。



## 【源由】

1、基于unity3d的移动游戏开发，在android与ios平台上的限制不同。在android上，我们可以拆分可执行文件为多个dll，然后运行时动态加载除主程序外的其它dll，这样也就允许了对dll的单独更新，然而ios上此路不通，ios禁止使用jit与动态加载dll。为了实现热更新，游戏行业一般采用lua。

2、从语言角度比较，c#是强类型的编译型语言，而lua是解释型的动态脚本语言，在工程规模达到一定程度时，lua由于缺少编译时类型推导与检查，错误更多推迟到运行时暴露，这显然是一个弱点。这与web前端语言javascript有点类似。

3、近年来在web前端语言javascript领域出现了一些添加编译器类型检查的需求，2个例子是CoffeeScript与微软的TypeScript，这2种语言都给javascript添加了强类型与推导，但他们不是直接编译或解释执行自身，而是编译到javascript，这样保证与web的兼容。这个工程尝试类似的工作，不过我们不设计新的语言，而是直接基于C#语法，自动编译为lua。

4、vs2015的c#编译器开源工程Rosyln在编译器语法与语义信息方面提供了非常完善的API，这帮我们完成了从c#->lua编译的主要工作。

5、c#->lua实现后，可以考虑两种用法：

  a、以不同平台均运行lua，此时用c#编写程序主要利用编译器的类型检查与推导功能及c#语言的诸多适合架构大型工程的语言设施。
  
  b、在ios平台上运行lua，在android平台上直接将用于转lua的c#工程编译为dll并动态加载，这样在不同平台实现热更新的机制不同，运行效率不同，但开发时只需要进行一次开发。



## 【C#->lua对c#的限制】

1、不完全支持类的继承与泛型（可以实现接口），主要原因是lua的元表机制很难完美实现c#对象继承的详细语义同时还保持良好的效率与可理解性。并且支持接口与partial类后，继承的很多特性可以很优雅的实现。

2、忽略异常相关语句（try/catch/finally/filter），简单支持只捕获Exception异常的try/catch/finally。

3、不支持指针与内存相关操作fixed/*/&/stackalloc。

4、不支持async/wait/lock等异步或并发相关设施。

5、不支持label与goto语句。

6、不支持checked/unchecked语句。

7、不支持linq语法糖（直接调用方法就可以，而且c#的linq支持本来也不如visual basic全，这语法风格与c#有点不搭，放弃了）。

8、自定义struct未完全实现拷贝语义（需要在lualib.lua里完善）。

9、不支持C# 7.0及以后版本引入的模式相关语法与本地方法。

*** CsToLuaUnimplemented.cs是目前明确不支持与不需要处理的语法特性（Visit开头的方法）.



## 【主要支持的c#特性】

1、类、方法、indexer、特性、事件、委托、字段等类定义相关的机制，静态与实例2类。

2、基本语句与表达式。

3、接口（转换时忽略）。

4、partial类。

5、预处理与属性，转换时处理，目标lua不包含。

6、类方法重载（overload非override）。

7、lambda表达式与lambda函数。

8、匿名类、匿名委托等。

9、自定义类部分支持generic（为每个generic实例生成一份代码，generic类本身不生成代码）。

10、数组与集合支持。

11、枚举支持。

12、支持ref/out参数。

13、扩展方法。

14、yield与协程。

15、操作符重载。

16、部分支持Attribute（目前会生成cs2lua_attributes.lua/txt文件，包含了所有自定义代码里用到的attribute，但lualib.lua里未实现自定义属性的访问机制）

17、部分支持自定义struct，语法层面基本完成，拷贝语义需要在lualib.lua里实现。

*** CsToLua.cs是目前支持的语法（Visit开头的方法）.



## 【支持在C#里用属性标记的额外特性】

1、Cs2Dsl.Ignore属性

用于在c#代码里标记类或方法不进行转换处理，使用它们的代码就像它们已经存在一样转换。（这一属性主要用于手动用lua实现一些c#代码的功能）

2、Cs2Dsl.Require(string luaModuleName)属性

用于指出c#代码在转换后需要require某个lua模块，与1同时用于不自动转换的c#代码用以支持手动实现c#代码对应的lua。单独使用就是简单在生成的lua代码里添加require语句。

3、Cs2Dsl.Entry属性

用于指明某个c#类的对应lua文件要生成一个入口方法，具体实现在lualib.lua里的defineentry函数，生成代码会调用defineentry。

4、Cs2Dsl.Export属性

用于指明某个c#类的构造在转换为lua后生成的供c#端调用的__new_object方法里用于对象构造。

5、Cs2Dsl.EnableInherit属性
 
用于指明某个c#类可能使用继承（此时转换到lua时不会报错），Cs2Lua会采用一种继承实现机制来实现继承，但与c#的继承语义不太一样，此属性用于使用都能确保使用一致继承的情形（就是说语义与c#是一致的），一般继承层次只有2层并且只涉及复用代码与纯虚函数重载的情形是可以的，子类隐藏父类非虚函数的情形要避免使用。

6、Cs2Dsl.TranslateTo(string luaModuleName, string targetMethodName)属性
 
用于指定某个方法翻译为调用指定lua模块的指定lua函数（要求目标lua函数签名与方法一致）。
 
7、Cs2Dsl.NeedFuncInfo属性

使用c#值类型的方法，因lua里没有值类型语义的实现，我们通过构造新对象来模拟值类型赋值的拷贝语义，此时为减少GC，采用对象池，这些对象需要记录在函数信息上，然后在方法结束时统一回收，这一属性用于标记某个方法应该生成函数信息（只用在翻译时认为方法不需要函数信息但人工需要的场合，比如作为入口函数，即便没有使用值类型，但为了配合其它方法对值类型的处理，也需要生成一个根函数信息）。



## 【用法】

1、建立一个C#工程，引用Cs2Lualualib.dll。

2、用vs开发功能，只使用Cs2Lua支持的语法构造。

3、运行Cs2Lua C#.csproj，生成该工程各C#类对应的lua代码，输出按类组织，每个类一个文件，输出时的类已经合并过（支持c# partial）

4、用slua封装供前面C#工程使用的其它DLL里的类。

5、将生成的lua文件放到unity3d工程里，按slua的规则启动其入口类。

理论上按此顺序即可。

*** 注意第3步的输出lua在工程文件所在目录下的lua目录里，日志在log目录里，必须检查日志文件确定没有错误才能继续！！！



## 【如何增加可以在c#里使用的API】

1、第一种方式就是在独立的C# dll里实现，然后用slua导出。

2、另一种方式其实可以在上面提到的lualib.lua里实现，就像我们提到的generic集合类一样（这种在dotnet系统dll里定义，所以c#代码可以直接使用，但由于slua并不导出，所以转化后的lua里要使用的话必须有额外的lua来实现）。这其实表明了两种情形：

a、所用的api在某个c# dll里已经定义了，但slua没有导出（上面说的就是这种情形），实现方式一种是在lualib.lua里实现，另外还有一个办法是单独加一个lua模块实现，并在c#代码里使用Cs2Lua.Require属性在使用它的类里标明一下依赖关系。

b、所用的api没有在c# dll里定义，所以也不会在slua里导出。这时需要在C#与lua里各实现一套，然后c#的实现标记为Cs2Lua.Ignore并同时使用Cs2Lua.Require标明对lua实现代码的依赖关系（当然也可将lua实现放在lualib.lua里，这样就不用标明依赖了，lualib.lua是默认要依赖的）。

