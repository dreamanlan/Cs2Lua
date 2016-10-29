# Cs2Lua
CSharp代码转lua，适用于使用lua实现热更新而又想有一个强类型检查的语言的场合

【源由】

1、基于unity3d的移动游戏开发，在android与ios平台上的限制不同。在android上，我们可以拆分可执行文件为多个dll，然后运行时动态加载除主程序外的其它dll，这样也v允许了对dll的单独更新，然而ios上此路不通，ios禁止使用jit与动态加载dll。为了实现热更新，游戏行业一般采用lua。

2、从语言角度比较，c#是强类型的编译型语言，而lua是解释型的动态脚本语言，在工程规模达到一定程度时，lua由于缺少编译时类型推导与检查，错误更多推迟到运行时暴露，这显然是一个弱点。这与web前端语言javascript有点类似。

3、近年来在web前端语言javascript领域出现了一些添加编译器类型检查的需求，2个例子是CoffeeScript与微软的TypeScript，这2种语言都给javascript添加了强类型与推导，但他们不是直接编译或解释执行自身，而是编译到javascript，这样保证与web的兼容。这个工程尝试类似的工作，不过我们不设计新的语言，而是直接基于C#语法，自动编译为lua。

4、vs2015的c#编译器开源工程Rosyln在编译器语法与语义信息方面提供了非常完善的API，这帮我们完成了从c#->lua编译的主要工作。

5、c#->lua实现后，可以考虑两种用法：

  a、以不同平台均运行lua，此时用c#编写程序主要利用编译器的类型检查与推导功能及c#语言的诸多适合架构大型工程的语言设施。
  
  b、在ios平台上运行lua，在android平台上直接将用于转lua的c#工程编译为dll并动态加载，这样在不同平台实现热更新的机制不同，运行效率不同，但开发时只需要进行一次开发。
  

【C#->lua对c#的限制】

1、不完全支持类的继承与泛型（可以实现接口），主要原因是lua的元表机制很难完美实现c#对象继承的详细语义同时还保持良好的效率与可理解性。并且支持接口与partial类后，继承的很多特性可以很优雅的实现。

2、忽略异常相关语句（try/catch/finally/filter）。

3、不支持指针与内存相关操作fixed/*/&/stackalloc。

4、不支持async/wait/lock等异步或并发相关设施。

5、不支持label与goto语句。

6、不支持checked/unchecked语句。

*** CsToLuaUnimplemented.cs是目前明确不支持与不需要处理的语法特性（Visit开头的方法）.

【主要支持的c#特性】

1、类、方法、indexer、特性、事件、委托、字段等类定义相关的机制，静态与实例2类。

2、基本语句与表达式。

3、接口（转换时忽略）。

4、partial类。

5、预处理与属性，转换时处理，目标lua不包含。

6、类方法重载（overload非override）。

7、lambda表达式与lambda函数。

8、匿名类、匿名委托等。

9、部分支持generic。

10、数组与集合支持。

11、枚举支持。

12、支持ref/out参数。

13、扩展方法。

14、yield与协程。

*** CsToLua.cs是目前支持的语法（Visit开头的方法）.

【额外特性】

1、Cs2Lua.Ignore属性

用于在c#代码里标记类或方法不进行转换处理，使用它们的代码就像它们已经存在一样转换。（这一属性主要用于手动用lua实现一些c#代码的功能）

2、Cs2Lua.Require属性

用于指出c#代码在转换后需要require某个lua模块，与1同时用于不自动转换的c#代码用以支持手动实现c#代码对应的lua。单独使用就是简单在生成的lua代码里添加require语句。

3、Cs2Lua.Entry属性

用于指明某个c#类的对应lua文件要生成一个入口方法，具体实现在utility.lua里的defineentry函数，生成代码会调用defineentry。

4、Cs2Lua.Export属性

用于指明某个c#类的构造在转换为lua后生成的供c#端调用的__new_object方法里用于对象构造。

5、Cs2Lua.EnableInherit属性

由于指明某个c#类可能使用继承（此时转换到lua时不会报错），Cs2Lua会采用一种继承实现机制来实现继承，但与c#的继承语义不太一样，此属性用于使用都能确保使用一致继承的情形（就是说语义与c#是一致的），一般继承层次只有2层并且只涉及复用代码与纯虚函数重载的情形是可以的，子类隐藏父类非虚函数的情形要避免使用。

【utility.lua里实现的部分】

1、位操作。

2、数组与集合的封装（用以支持IList、IDictionary接口）。

3、对应的lua对象机制（field、method、property、event、inherit）。

4、委托机制。

【生成的lua与C#的互操作】

1、目标是不依赖特定的交互机制（相关依赖都在utility.lua里，转换工具只处理语法直接支持的语义转换）。

2、目前仅测试了基于Slua的交互。

【基本思路】

1、语法制导的翻译。（c#语法、语义直接使用Rosyln工程）

2、C# class/struct -> lua table + metatable

3、数组、集合 -> lua table

4、表达式 -> lua表达式 + 匿名函数调用

5、c#语句 -> lua语句 + 匿名函数调用

6、lambda/delegate/event -> 函数对象

7、inherit/property/event interface implementation -> metatable __index/__newindex

8、generic -> 转化为普通类与方法，类型参数（类与方法均是）转化为普通参数，代码里明确用到类型参数的地方只有typeof操作

9、interface -> 直接忽略

【比较复杂的转换】

1、ref/out参数【假设C#函数定义int f(int a, int b, ref int c, out int d)】 

  r = f(a,b,ref c,out d) 

=>  

  r,c,d = f(a,b,c)
  
2、带ref/out参数函数出现在表达式中  

  v1+v2+f(a,b,ref c,out d)   
  
=>   
  
  v1+v2+(function() local r; r,c,d = f(a,b,c); return r; end)()  
  
3、复合赋值  

  a+=f(a,b,ref c,out d)   

=>   

  a = a + (function() local r; r,c,d = f(a,b,c); return r; end)()
  
4、对象创建

  var o = new Class(a,b) { m_F = 123, m_F2 = 456 }   
  
=>   
  
  local o = (function() local obj; obj = Class(a,b); (function(self) self.m_F = 123; self.m_F2 = 456; end)(obj); return obj; end)() 
    
5、循环中的continue实现

  while(a<b)
  
  {
  
    ++a;
    
    if(a<10)
    
      continue; 
      
    if(a>100)
    
      break;
      
    ++a;
    
  }
  
=> 
  
  while a < b do 
  
    local isBreak = false; 
    
    repeat 
    
      a=a+1; 
      
      if a>2 then 
      
        isBreak=false; 
        
        break; 
        
      end;
      
      if a>100 then
      
        isBreak=true;
        
        break;
        
      end;
      
      a=a+1;
      
    until true;
    
    if isBreak then
    
      break;
      
    end;
    
  end;

6、switch中的break实现（与5类似，不需要引用额外变量）

  switch(cond)
  
  {
  
  case 1:
  
      if(a+b<12)
      
        break;
        
      a+=2;
      
      b+=4;
      
      c=a*b;
      
      break;
      
  default:
  
      c=123;
      
      break;
      
  case 2:
  
      c=456;
      
      break;
      
  }
  
=>
  
  if cond==1 then
  
    repeat
    
      if a+b<12 then
      
        break;
        
      end;
      
      a=a+2;
      
      b=b+4;
      
      c=a*b;
      
      break;
      
    until true;
    
  elseif cond==2 then
  
    repeat
    
      c=456;
      
      break;
      
    until true;
    
  else
  
    repeat
    
      c=123;
      
      break;
      
    until true;
    
  end;
  
【特殊处理】

1、转换出的lua代码不使用self表示对象自己，而是使用this表示对象自己，这样无需处理c#代码里用self作变量名的情形。类似的，转换出的lua使用base来表示父

类子对象。类似的，property的get/set方法名也仍然是get/set，event接口实现的add/remove方法名也仍然使用add/remove。

2、泛型类静态方法与泛型方法在转换时会将泛型参数当函数参数作用，泛型类实例在构造时记录泛型参数到实例字段，实例方法通过字段获得泛型参数信息。

亦即

void GenericMethod<T>()

{

}

=>

GenericMethod = function(this, T)


end

再如

class GenericClass<TypeT>

{

  static void GenericMethod<T>()
  
  {
  
  }
  
}

=>

GenericClass = {

  GenericMethod = function(T, TypeT)
  
  end,
    
}

***这种转换方法能适应unity3d的GetComponent方法

GetComponent<T>() => GetCompoent(Type)
  
【用法】

1、建立一个C#工程，引用Cs2LuaUtility.dll。

2、用vs开发功能，只使用Cs2Lua支持的语法构造。

3、运行Cs2Lua C#.csproj，生成该工程各C#类对应的lua代码，输出按类组织，每个类一个文件，输出时的类已经合并过（支持c# partial）

4、用Slua或其它方式封装供前面C#工程使用的其它DLL里的类。

5、将生成的lua文件放到unity3d工程里，按Slua的规则启动其入口类。

理论上按此顺序即可。

*** 注意第3步的输出lua在工程文件所在目录下的lua目录里，日志在log目录里，必须检查日志文件确定没有错误才能继续！！！
