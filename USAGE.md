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

    2、所有名字空间的定义lua文件，此文件被1中文件引用，输出文件为cs2lua__namespaces.lua/txt。
    
    3、所有接口的定义lua文件，输出文件为cs2lua__interfaces.lua/txt。
    
    4、所有外部枚举的名称/值对应关系lua文件，输出文件为cs2lua__externenums.lua/txt。
    
    5、所有类的attribute信息文件，输出文件为cs2lua__attributes.lua/txt。

    6、Cs2Lua依赖的lualib文件syslib.lua，输出文件名为cs2lua__syslib.lua/txt。

    7、在c#代码里使用Cs2Lua.Require明确指明要依赖的lualib文件，这些文件需要自己放到Cs2Lua.exe所在目录的子目录lualib里，之后自动拷到输出目录。



## 【源由】

1、基于unity3d的移动游戏开发，在android与ios平台上的限制不同。在android上，我们可以拆分可执行文件为多个dll，然后运行时动态加载除主程序外的其它dll，这样也就允许了对dll的单独更新，然而ios上此路不通，ios禁止使用jit与动态加载dll。为了实现热更新，游戏行业一般采用lua。

2、从语言角度比较，c#是强类型的编译型语言，而lua是解释型的动态脚本语言，在工程规模达到一定程度时，lua由于缺少编译时类型推导与检查，错误更多推迟到运行时暴露，这显然是一个弱点。这与web前端语言javascript有点类似。

3、近年来在web前端语言javascript领域出现了一些添加编译器类型检查的需求，2个例子是CoffeeScript与微软的TypeScript，这2种语言都给javascript添加了强类型与推导，但他们不是直接编译或解释执行自身，而是编译到javascript，这样保证与web的兼容。这个工程尝试类似的工作，不过我们不设计新的语言，而是直接基于C#语法，自动编译为lua。

4、vs2017的c#编译器开源工程Rosyln在编译器语法与语义信息方面提供了非常完善的API，这帮我们完成了从c#->lua编译的主要工作。

5、c#->lua实现后，可以考虑两种用法：

  a、以不同平台均运行lua，此时用c#编写程序主要利用编译器的类型检查与推导功能及c#语言的诸多适合架构大型工程的语言设施。
  
  b、在ios平台上运行lua，在android平台上直接将用于转lua的c#工程编译为dll并动态加载，这样在不同平台实现热更新的机制不同，运行效率不同，但开发时只需要进行一次开发。



## 【C#->lua对c#的限制】

1、不完全支持类的继承与泛型（可以实现接口），主要原因是lua的元表机制很难完美实现c#对象继承的详细语义同时还保持良好的效率与可理解性。并且支持接口与partial类后，继承的很多特性可以很优雅的实现。

2、忽略异常相关语句（try/catch/finally/filter），可以支持只捕获Exception异常的try/catch/finally（默认未开启），仅当try块只有一条函数调用语句时没有性能影响（使用xpcall调用try块代码，所以有多条语句或非函数调用语句时需要包装成function对象）。

3、不支持指针与内存相关操作fixed/*/&/stackalloc。

4、不支持async/wait/lock等异步或并发相关设施。

5、不支持label与goto语句。

6、不支持checked/unchecked语句。

7、不支持linq语法糖（直接调用方法就可以，而且c#的linq支持本来也不如visual basic全，这语法风格与c#有点不搭，放弃了）。

8、自定义struct未完全实现拷贝语义（lua语言没有自定义值类型，cs2lua翻译时对值类型赋值委托到lualib的函数，需要在lualib.lua里针对具体类型复制新实例，一般来说需要使用对象池来减少GC，cs2lua通过自定义转换脚本generator.dsl允许定制值类型的各类处理，另外说明）。

9、不支持C# 7.0及以后版本引入的模式相关语法与本地方法，使用的roslyn库更新到15.9，支持c# 7.3及以下版本的工程的翻译。c# 8.0/9.0暂不考虑支持（语言变化过大，各类语法糖可能会导致比较多性能问题，同时对lualib的需求也会比较多，可能导致翻译后的定制工作量加大）。

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

17、部分支持自定义struct，语法层面基本完成，拷贝语义需要在lualib.lua里与generator.dsl里实现。

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
 
用于指定某个方法翻译为调用指定lua模块的指定lua函数（要求目标lua函数签名与方法一致），这是1与2之外另一种人工翻译到lua的办法。
 
7、Cs2Dsl.NeedFuncInfo属性

使用c#值类型的方法，因lua里没有值类型语义的实现，我们通过构造新对象来模拟值类型赋值的拷贝语义，此时为减少GC，采用对象池，这些对象需要记录在函数信息上，然后在方法结束时统一回收，这一属性用于标记某个方法应该生成函数信息（只用在翻译时认为方法不需要函数信息但人工需要的场合，比如作为入口函数，即便没有使用值类型，但为了配合其它方法对值类型的处理，也需要生成一个根函数信息）。



## 【用法】

1、建立供lua调用的C# api工程，可以使用C#的所有语法特性，但public类及其方法需要符合slua导出API的要求（主要是不能使用generic类型，避免使用params参数与值类型）。

2、建立一个准备翻译到lua的C#工程，此工程添加Cs2DslUtility.dll（从而允许使用上面提到的7种属性标记）与1中api.dll的引用（如果希望lua直接访问unity3d API，可以添加UnityEngine.dll引用，注意只能依赖供lua使用的API的DLL与mscorlib.dll和System.dll，并且要只使用系统dll里的会导出成lua API的类型或lualib里会人工实现lua版本的功能），用vs开发功能，需要只使用Cs2Lua支持的语法构造。

3、运行Cs2Lua C#.csproj，生成该工程各C#类对应的lua代码，输出按类组织，每个类一个文件，输出时的类已经合并过（支持c# partial）

4、用slua封装供前面C#工程使用的api DLL（三类：api工程dll、UnityEngine.dll和mscorlib/System.dll）里的类（通过修改CustomExport.cs配置要导出的dll与unity api等，然后使用slua菜单生成API包装代码），包装类代码建议放到SluaExport.csproj里，编译为SluaExport.dll。

5、装SluaExport.dll与SluaManaged.dll放到unity3d工程的plugins目录下。

6、在unity3d启动脚本里调用Slua的启动代码，加载并运行入口lua脚本。

理论上按此顺序即可（细节可参考示例工程[ https://github.com/dreamanlan/Cs2Lua/tree/master/Test ]）。

*** 注意第3步的输出lua在工程文件所在目录下的lua目录里，日志在log目录里，必须检查日志文件确定没有错误才能继续！！！



## 【如何增加可以在c#里使用的API】

1、第一种方式就是在独立的C# API dll里实现，然后用slua生成包装代码，编译到SluaExport.dll中。

2、另一种方式是C#的实现可能想在lua里人工实现，不使用c#版本，这种情况一般可以在上面提到的syslib.lua里实现，就像我们提到的generic集合类一样（这种在dotnet系统dll里定义，所以c#代码可以直接使用，但由于slua并不导出，所以转化后的lua里要使用的话必须有额外的lua来实现）。这其实表明了两种情形：

a、所用的api在某个c# API dll里已经定义了，但slua没有导出（上面说的就是这种情形），实现方式一种是在lualib.lua里实现，另外还有一个办法是单独加一个lua模块实现，并在c#代码里使用Cs2Lua.Require属性在使用它的类里标明一下依赖关系。

b、所用的api没有在c# API dll里定义，所以也不会在slua里导出。这时需要在翻译到C#的工程与lua里各实现一套，然后c#的实现标记为Cs2Lua.Ignore并同时使用Cs2Lua.Require标明对lua实现代码的依赖关系（当然也可将lua实现放在syslib.lua里，这样就不用标明依赖了，syslib.lua是默认要依赖的）。



## 【开发注意事项】

***【基本规则】

1、三个工程的依赖关系：CSharp-Assembly依赖CustomApi，Cs2LuaScript依赖CustomApi，CSharp-Assembly通过代理依赖Cs2LuaScript的public类（一般是逻辑入口类，用以初始化或驱动心跳）。

2、逻辑代码默认都添加到Cs2LuaScript工程里。

3、Cs2LuaScript里的类默认都使用internal访问修饰，这样可以避免在Assembly-CSharp工程里直接调用Cs2LuaScript的代码（直接调用的都需要修改，否则将来翻译为lua后无法运行）。

4、Cs2LuaScript工程里尽量只采用基于对象的方式开发，避免使用继承，不要使用vs2015以后的新语法，不要使用LINQ。

5、CustomApi工程里的类，不需要被Cs2LuaScript工程使用与CSharp-Assembly工程使用的，加上internal修饰，这可以减少slua生成的封装代码的数量

6、异常处理在lua里有比较大的GC，所以翻译时只对try块部是是单一函数调用的try-catch采用异常处理，多语句try块的异常处理会忽略，确实需要异常处理的需要将try块的语句单独写一个函数，然后保证try块里只有一个函数调用。

7、lua函数对象与upvalue都有比较大的GC，++/--运算符尽量单独写一个表达式，在if语句条件里使用TryGetValue的调用时，尽量保证条件表达式只是TryGetValue的调用或者，单独写TryGetValue并把结果记到变量里，然后在if语句条件里使用该变量。（while/do-while语句里使用时与此类似）。

8、lua语言没有值类型，值类型的lua对应类实际是普通类，cs2lua在翻译赋值语句时通过构造新的类实例来模拟值类型的语义行为，并通过对象池来避免构造实例的GC开销。但slua导出的API里，值类型作为property或方法返回值的，slua都会构造一个新的lua userdata。所以应尽量避免使用这些property与方法，我们会在CustomApi提供相应的替代方法。

***【CustomApi工程注意事项：】

0、这个模块不支持线上热更新，所以这里实现的功能都是偏底层与性能敏感的，原则上这里的功能都应该考虑如何支持Cs2LuaScript工程里进行扩展。从长远来看，这个工程里的代码应该是趋于稳定的，上线前应该尽量减少接口的添加与修改，上线后应该尽量不修改。

1、CustomApi相关的各dll，public方法都会由slua导出API，slua有一个限制是它不会导出generic类与方法。所以public方法需要避免使用generic类做参数或返回值（确实需要的可以使用继承来明确绑定generic的类型参数到具体类型，CustomApi工程里已经有一些这样的实现如IntList,StrList,IntIntDict,StrStrDict等）

2、目前没有太好的办法实现c#的struct的值拷贝语义，避免导出CustomApi里的struct给lua（实在有必要的需要手写lua代码与修改slua来实现）。

3、slua不能正常导出多个重载都带有params参数的方法(另外考虑到GC问题，应该不要使用params参数)。

***【Cs2LuaScript工程注意事项：】

0、其他工程不应直接引用Cs2LuaScript工程，Cs2LuaScript里所有的类都应该是internal的，不应有public的类（除入口类外，public的类在其它工程里也应通过C#代理类访问）。

1、Cs2LuaScript工程在ios上将翻译为lua运行，因此编写时要注意不要使用特别花哨的语法。

2、Cs2LuaScript工程里不要使用64位整数，应该自己封装一个64位整数类（这是因为使用luajit的原因，lua 5.1里数只有double）。

3、Cs2LuaScript工程里的类，没有被继承的，都加上sealed修饰，这会指导cs2lua翻译时减少方法信息

4、delegate的调用直接像函数那样调，不要写成.Invoke。因为翻译成lua时delegate对应到lua function，是没有Invoke方法的。

5、generic方法在翻译时会将类型参数作为普通参数放在实际调用参数前，比如GetComponent<T>()实际翻译后调用的是GetComponent(Type)方法，如果确实需要用到Type类型的参数，在定义generic方法后，需要定义一个同名的非generic方法，并将generic参数变为普通Type类型的参数。

6、目前没有太好的办法实现c#的struct的值拷贝语义，所以struct现在翻译后也是引用的方式，在Cs2LuaScript工程里尽量避免使用struct。

7、继承只能支持最简单的实现继承与不涉及基类子对象的虚函数，所以在Cs2LuaScript工程里尽量不要用继承。

8、Cs2LuaScript里允许使用接口，但Cs2LuaScript翻译为lua后这些实现接口的类都是lua table，所以其实并不能真的实现c#的接口，所有Cs2LuaScript工程里继承或实现CustomApi里的接口（或抽象类）的对象，都需要在c#端添加一个代理类来实现c#的接口实现或继承语义，然后各个方法的实现委托到相应的lua方法。（实际用起来会比较麻烦，所以能避免也尽量避免）

9、lua里的数都是double类型，对于采用格式化参数的接口会有问题，比较典型的是string::Format与StringBuilder::AppendFormat，我们提供了2个替代方法Utility::Format与Utility::AppendFormat，使用时注意使用替代方法

10、类的静态成员的初始化不要直接在定义成员时初始化，提供一个Property，在get里判断是否为空并初始化。

11、枚举翻译时直接按整数常量处理，在lua端没有对应的枚举类型，因此在Cs2LuaScript工程定义的generic类的类型参数不能是枚举。

12、这个工程里不要继承List、Dictionary、HashSet等泛型容器，确实需要的使用组合方式，自己暴露一下接口。（这几个容器类被视作语言内建的机制，与自定义类的机制不太一样）

13、Cs2LuaScript工程里的generic类翻译为lua时是按模板实例化的方式处理的，这与c#的语义并不完全一致，不能使用依赖运行时实例化的generic样式。

14、Cs2LuaScript里定义的数组会翻译为lua里的table，这个数组可以值传递给c#端，但不能按引用传递，也就是说暴露的api不应该接收一个数组，然后修改数组的元素。

15、尽量不要使用多维数组，代之以使用jagged数组，多维数组翻译为lua时实际上是按jagged数组处理的。

16、cs2lua采用类似C++模板实例化的方式来翻译泛型类，为了保证不同实例的方法使用一样的签名，方法参数是泛型类时，签名使用泛型类的泛型形参而不使用实参。这意味着不能支持2个重载函数仅依靠泛型参数的实参类型来区分。

17、目前的lua端对象模型有个缺陷，在继承的时候，子类和基类的变量名不能重名，重名会导致lua调用基类的方法访问基类变量时，改为访问子类同名变量，导致出错。（这个可以修改lua对象模型来解决，但比较麻烦，暂未考虑）

**【CSharp-Assembly（即Unity3d生成的工程）注意事项：】

0、这个模块不支持线上热更新，这里主要实现游戏启动相关逻辑及与引擎功能直接相关的表现逻辑（辅助shader挂脚本的方式）。长远看，这个模块应该避免频繁的修改。引擎表现相关的脚本需要研究如何不修改c#代码的情况下支持新的shader。

1、这里的脚本可以使用CustomApi里的公共类与方法，但不能直接引用Cs2LuaScript里的类与方法（作为检查机制，Cs2LuaScript里的所有的类都应该是internal的）。

2、必须要访问Cs2LuaScript工程里的类时，需要在CustomApi里定义对应的接口，然后针对c# dll与lua两种情形分别处理，lua情形时需要添加代理c#类。



## 【自定义翻译】

cs2lua从c#到lua的翻译分为两步进行：

第一步是去语法糖，就是将c#语法进行简化，翻译到一个基于DSL的中间语言，这个中间语言是弱类型、支持函数、匿名函数对象与面向对象的C风格脚本语言。C#的很多特有的语言特性会翻译为一个函数调用（可以理解为是对翻译时/运行时支持函数的调用）。

第二步是从中间语言转换到lua，这一步主要包括：

1、将类结构翻译为lua语言的table加元表处理的样式。

2、将语句翻译为lua语言对应的语句，如if/else，while，do/while，for，foreach，try/catch/finally，using等。

3、按lua语言的特点转换中间语言里对各个支持函数的调用到lua语言语法或lualib的支持函数调用。

cs2lua在第3步提供了一个扩展机制，对每个支持函数的翻译，会先调用generator.dsl，如果dsl已经处理了此翻译，cs2lua就不再处理。这样提供了通过generator.dsl对特定支持函数的翻译定制。具体的支持函数可以查看LuaGenerator_Main.cs代码里的GenerateConcreteSyntaxForCall方法的各if分支，我们一般需要定制处理的是最后转换到lua后调用lualib里支持函数的这些。

从我们实际项目的情况看，主要是对各种值类型的处理需要定制，这包括如下这些支持函数：

* invokeexternoperatorreturnstruct(rettype, class, method, ...)
* wrapoutstruct(v, classObj)
* wrapoutexternstruct(v, classObj)
* wrapstruct(v, classObj)
* wrapexternstruct(v, classObj)
* getexterninstancestructmember(symKind, obj, class, member)
* callexterndelegationreturnstruct(funcobj, funcobjname, ...)
* callexternextensionreturnstruct(class, member, ...)
* callexternstaticreturnstruct(class, member, ...)
* callexterninstancereturnstruct(obj, class, member, ...)
* recycleandkeepstructvalue(fieldType, oldVal, newVal)

这些支持函数主要是为了给值类型添加对象池的，因为lua里没有值类型，c#里使用的值类型翻译到lua时，对值类型的赋值语义，需要产生一个新的值相同的实例，如果只是创建新实例，这样会导致非常多的lua GC，这时我们一般需要采用对象池来减少GC，这样在整体上通过反复使用几个实例能比较好的模拟值类型处理。为了配合对象池的操作，cs2lua对涉及值类型操作的方法，会在函数入口调用luainitialize生成一个函数信息，然后值类型操作的各个支持函数会将对象池里分配出的实例记录到函数信息上，最后在函数返回前调用luafinalize将函数信息里记录的值类型实例进行回收。

我们来看一个实例，下面的RefreshTargetPosition方法就是一个包含值类型处理的方法，cs2lua翻译时会在入口调luainitialize，返回前调用luafinalize，单独把方法体包装成一个函数__ori_RefreshTargetPosition是为了在异常时保证luainitialize/luafinalize的调用是成对的。

```
    RefreshTargetPosition = function(this, leader, npc)
        local __cs2lua_func_info = luainitialize();
        local __retval_0, __retval_1 = luapcall(this.__ori_RefreshTargetPosition, this, __cs2lua_func_info, leader, npc);
        __cs2lua_func_info = luafinalize(__cs2lua_func_info);
        if not __retval_0 then
        	error(__retval_1);
        	__retval_1 = nil;
        end;
        return __retval_1;
    end,
    __ori_RefreshTargetPosition = function(this, __cs2lua_func_info, leader, npc)
        local __method_ret_53_4_69_5;
        if (((isequal(leader, nil) or isequal(leader.View, nil)) or isequal(npc, nil)) or isequal(npc.View, nil)) then 
        	__method_ret_53_4_69_5 = false;
        	return __method_ret_53_4_69_5;
        end;
        local target_pos;
        target_pos = get_entityviewmodel_position(__cs2lua_func_info, leader.View);
        local origin_pos;
        origin_pos = get_entityviewmodel_position(__cs2lua_func_info, npc.View);
        --距离超过3m进行跟随
        local t;
        t = this:CalculateTargetPos(target_pos, get_tranform_forward(__cs2lua_func_info, leader.View:GetGameObject().transform));
        t = wrap_vector3(__cs2lua_func_info, t);
        local sqrdis;
        sqrdis = UnityEngine.Vector3.SqrMagnitude(invokeexternoperatorreturnstructimpl(__cs2lua_func_info, UnityEngine.Vector3, UnityEngine.Vector3, "op_Subtraction", t, origin_pos));
        if (((((sqrdis > 0.25000000) or leader.movementInfo.controllerManager:IsMove())) and (not leader.movementInfo.controllerManager:IsSwim())) and (not leader.movementInfo.controllerManager:IsJumping())) then 
        	AiCommand.AiPursue(npc, t, false);
        else
        	npc.View:GetGameObject().transform.forward = get_tranform_forward(__cs2lua_func_info, leader.View:GetGameObject().transform);
        end;
        __method_ret_53_4_69_5 = true;
        return __method_ret_53_4_69_5;
   end,
```

这个方法里的get_entityviewmodel_position、get_tranform_forward、wrap_vector3、invokeexternoperatorreturnstructimpl都是自定义翻译的结果，在中间语言dsl里，这几个支持函数是这样的：

```
    local(target_pos); target_pos = getexterninstancestructmember(SymbolKind.Property, getexterninstance(SymbolKind.Property, leader, CsLibrary.EntityInfo, "View"), CsLibrary.EntityViewModel, "position");
    local(origin_pos); origin_pos = getexterninstancestructmember(SymbolKind.Property, getexterninstance(SymbolKind.Property, npc, CsLibrary.EntityInfo, "View"), CsLibrary.EntityViewModel, "position");
    comment("距离超过3m进行跟随");
    local(t); t = callinstance(this, AiFollow, "CalculateTargetPos", target_pos, getexterninstancestructmember(SymbolKind.Property, getexterninstance(SymbolKind.Property, callexterninstance(getexterninstance(SymbolKind.Property, leader, CsLibrary.EntityInfo, "View"), CsLibrary.EntityViewModel, "GetGameObject"), UnityEngine.GameObject, "transform"), UnityEngine.Transform, "forward"));
    t = wrapexternstruct(t, UnityEngine.Vector3);
    local(sqrdis); sqrdis = callexternstatic(UnityEngine.Vector3, "SqrMagnitude", invokeexternoperatorreturnstruct(UnityEngine.Vector3, UnityEngine.Vector3, "op_Subtraction", t, origin_pos));
```          

然后在generator.dsl里有这样的处理代码：

```
    script(wrapexternstruct)args($funcData, $funcOpts, $sb, $indent)
    {
        //wrapexternstruct(v, classObj)
        $classObj = getargument($funcData, 1);

        if($classObj=="UnityEngine.Vector3"){
            usefunc("wrap_vector3","(funcInfo, v)", $funcData, $funcOpts, $sb, $indent, [1], "__cs2lua_func_info")
            {:
                local obj = UnityEngine.Vector3.New(v.x,v.y,v.z)
                table.insert(funcInfo.v3_list, obj)
                return obj
            :};
            return(true);
        };
        return(false);
    };

    script(getexterninstancestructmember)args($funcData, $funcOpts, $sb, $indent)
    {
        //getexterninstancestructmember(symKind, obj, class, member)
        $symKind = getargument($funcData, 0);
        $class = getargument($funcData, 2);
        $member = getargument($funcData, 3);
            
        if($class=="UnityEngine.Transform"){
            if($member=="forward"){
                usefunc("get_tranform_forward","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
                {:
                    local _,x,y,z = Utility.GetForward(obj, Slua.out, Slua.out, Slua.out)
                    local v = UnityEngine.Vector3.New(x,y,z)
                    table.insert(funcInfo.v3_list, v)
                    return v
                :};
                return(true);
            };
        }
        elseif($class=="CsLibrary.EntityViewModel"){
            if($member=="position"){
                usefunc("get_entityviewmodel_position","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
                {:
                    local _,x,y,z = obj:GetPosition(Slua.out, Slua.out, Slua.out)
                    local v = UnityEngine.Vector3.New(x,y,z)
                    table.insert(funcInfo.v3_list, v)
                    return v
                :};
                return(true);
            }
            elseif($member=="SyncOffset"){
                usefunc("get_entityviewmodel_syncoffset","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
                {:
                    local _,x,y,z = obj:GetSyncOffset(Slua.out, Slua.out, Slua.out)
                    local v = UnityEngine.Vector3.New(x,y,z)
                    table.insert(funcInfo.v3_list, v)
                    return v
                :};
                return(true);
            };
        };
        return(false);
    };

    script(invokeexternoperatorreturnstruct)args($funcData, $funcOpts, $sb, $indent)
    {
        //invokeexternoperatorreturnstruct(rettype, class, method, ...)
        $rettype = getargument($funcData, 0);
        $class = getargument($funcData, 1);
        $method = getargument($funcData, 2);
        
        //首行的缩进cs2lua已经处理，新行需要自己添加缩进
        //writeindent($sb, $indent);
        writesymbol($sb, "invokeexternoperatorreturnstructimpl");
        writesymbol($sb, "(__cs2lua_func_info, ");
        writearguments($sb, $funcData, $funcOpts, $indent, 0);
        writesymbol($sb, ")");
        return(true);
    };
```

可以看到，自定义翻译是对支持函数按参数值识别并进行处理（注意最后自己输出的函数调用结尾是不需要加分号的），处理不了的情形返回false，则走cs2lua的默认翻译流程。一般来说都是根据class或member名字来进行自定义处理。

自定义处理脚本generator.dsl里可以使用的API如下（$开头的参数引用generator.dsl里支持函数处理脚本的参数，一般不需要修改为其它，$funcData是DSL元语言里的Dsl.FunctionData，是加载到内存的中间语言的函数调用；$funcOpts是当前翻译语句所属类方法的选项，包含方法参数与返回值类型信息，通常用不着；$sb是输出代码的StringBuilder实例，$indent是当前语句的缩进值）：

1、getargument($funcData, index);
    
从$funcData里读取index参数的值，只有参数是类型或字符串时返回值，一般这些值用于判断是否需要进行自定义翻译处理。
    
2、writeindent($sb, indent);
    
往StringBuilder输出流$sb里输出indent数量的缩进。
    
3、writesymbol($sb, "code");
    
往StringBuilder输出流$sb里输出一个符号，可以是标识符或者分隔符、括号等。
    
4、writestring($sb, "string");
    
往StringBuilder输出流$sb里输出一个字符串，与输出标识符的差别是会在输出首尾加上引号。
    
5、writearguments($sb, $funcData, $funcOpts, $indent, start_arg_index_or_ignore_args);
    
往StringBuilder输出流$sb里输出函数参数，最后一个参数可以是一个整数，指明起始参数索引，或者是一个数组（方括号括起来的数字列表），数组指明要忽略的参数，忽略参数一般是在generator.dsl里已经用于判断是否自定义翻译的参数，这些参数在运行时可能用不上了，可以忽略（需要与lualib或lualib_special里的实现一致）。
    
6、usefunc(lua_func_name, lua_func_params_string, $funcData, $funcOpts, $sb, $indent, start_arg_index_or_ignore_args, [addargs, ...])

{:

    lua_func_code
    
:};


定义一个自定义lua函数，并将当前支持函数翻译为调用此lua函数。lua_func_name是自定义lua函数的名字，cs2lua用来唯一标识这段代码（也就是只输出一份函数定义），lua_func_params_string是自定义lua函数的参数列字符串（包括起止括号），start_arg_index_or_ignore_args参数与5中同名参数作用相同，addargs是可变参数列表，指出相对中间语言，自定义lua函数要额外添加的参数，这些参数都加在自定义函数普通参数的前面，目前一般只有一个额外参数是"__cs2lua_func_info"，用来引用当前方法的函数信息（函数信息的名字是cs2lua约定的，不能更改）（注意，这些额外参数需要与lua_func_params_string的参数表数量一致）。lua_func_code是自定义lua函数的实现代码（不包括函数头与结尾的end）,这段代码用{:和:}括起来，这是用作中间语言的DSL元语言里包含外部脚本的语法。


## 【性能优化参考】



