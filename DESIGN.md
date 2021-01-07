# Cs2Lua
CSharp代码转lua，适用于使用lua实现热更新而又想有一个强类型检查的语言的场合



## 【源由】

1、基于unity3d的移动游戏开发，在android与ios平台上的限制不同。在android上，我们可以拆分可执行文件为多个dll，然后运行时动态加载除主程序外的其它dll，这样也就允许了对dll的单独更新，然而ios上此路不通，ios禁止使用jit与动态加载dll。为了实现热更新，游戏行业一般采用lua。

2、从语言角度比较，c#是强类型的编译型语言，而lua是解释型的动态脚本语言，在工程规模达到一定程度时，lua由于缺少编译时类型推导与检查，错误更多推迟到运行时暴露，这显然是一个弱点。这与web前端语言javascript有点类似。

3、近年来在web前端语言javascript领域出现了一些添加编译器类型检查的需求，2个例子是CoffeeScript与微软的TypeScript，这2种语言都给javascript添加了强类型与推导，但他们不是直接编译或解释执行自身，而是编译到javascript，这样保证与web的兼容。这个工程尝试类似的工作，不过我们不设计新的语言，而是直接基于C#语法，自动编译为lua。

4、vs2015的c#编译器开源工程Rosyln在编译器语法与语义信息方面提供了非常完善的API，这帮我们完成了从c#->lua编译的主要工作。

5、c#->lua实现后，可以考虑两种用法：

  a、以不同平台均运行lua，此时用c#编写程序主要利用编译器的类型检查与推导功能及c#语言的诸多适合架构大型工程的语言设施。
  
  b、在ios平台上运行lua，在android平台上直接将用于转lua的c#工程编译为dll并动态加载，这样在不同平台实现热更新的机制不同，运行效率不同，但开发时只需要进行一次开发。
 
 

## 【基本思路】

1、语法制导方式翻译到DSL（可以理解为简化了语法特性的中间语言），再由DSL经由生成器转换为lua。（c#语法、语义直接使用Rosyln工程）

2、C# class/struct -> lua table + metatable

3、inherit/property/event interface implementation -> metatable __index/__newindex

4、lambda/delegate/event -> 函数对象

5、generic -> 为每个generic实例生成一份代码，generic类本身不生成代码

6、interface -> 直接忽略

7、数组、集合 -> lua table

8、表达式 -> lua表达式 + 匿名函数调用

9、c#语句 -> lua语句 + 匿名函数调用



## 【比较复杂的转换】

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
  
  
  
## 【特殊处理】

1、转换出的lua代码不使用self表示对象自己，而是使用this表示对象自己，这样无需处理c#代码里用self作变量名的情形。类似的，转换出的lua使用base来表示父类子对象。类似的，property的get/set方法名也仍然是get/set，event接口实现的add/remove方法名也仍然使用add/remove。

2、泛型方法在转换时会将泛型参数当函数参数作用。

亦即

void GenericMethod<T>()

{

}

=>

GenericMethod = function(this, T)


end

***这种转换方法能适应unity3d的GetComponent方法

GetComponent<T>() => GetCompoent(Type)

3、为与Slua及dotnet reflection调用的机制一致，函数的out参数在调用时传入实参__cs2lua_out（使用Slua时此值为Slua.out否则为一空表）。

4、修改了Slua导出API识别重载版本的机制，修改为每个重载版本导出一个换名后的API，这样可以精确匹配调用的方法。

5、对于翻译为lua的C#类，如果其实例传给C#对象的object类型属性，slua是无法记录的，翻译时对这种情形添加了luatoobject/objecttolua两个库调用，使用一个继承自c#实现的类型的翻译为lua的类，然后将
普通lua类型实例作为该类的字段，并把该类实例赋给C#对象的object类型属性。从c#对象的object类型属性读取时，则进行反向操作，从而得到普通lua类实例。在FairyGUI里，常将业务对象赋给UI对象，并在事件
处理里再取回使用。这其实是windows系统常见的custom data方式。

6、c#里用方法名作参数时，编译器会自动包装成delegate，并且多次使用代表同一个delegate，这样可以让delegate/event的add/remove都传函数名即可。但这种函数名在lua里需要包装成函数对象，lua里对同一
函数名的多次封装并不能识别为同一个delegate，这样就导致add后remove不掉对应的delegate。这个机制我们采用函数对象只在第一次构建时创建并在后续使用时能取回来处理：

(function()
  local delegate_key = calcdelegationkey(obj_member_key, obj);
  return builddelegationonce(delegate_key, getdelegation(delegate_key) or function(...) return obj:member(...); end)
end)()

这里有2个关键点，一个是为每个函数名代表的delegation定义一个delegate_key，由三部分构成：对象名、方法名、对象实例ID，然后在一个全局表里以弱表方式记录key对应的lua函数对象。另一个是作为参数传递
时，利用表达式短路的机制，getdelegation(delegate_key) or 函数对象定义，这样保证如果能取到已经定义的函数对象，就不会定义新的（避免函数对象开销）。builddelegationonce所做的工作是，根据delegate_key取回已经定义的函数对象（与getdelegation函数一样，从全局表里读取，可以是nil，表明不存在），然后与第二个参数比较，如果相同就直接返回取到的对象，否则记录第二个参数到全局表里，并返回第二个参数对象。

7、lua里用table作类时，数据成员如果为nil，则表示这个成员在table里不存在。在继承情形需要在当前类未找到字段时访问父类字段，如果按table查找的话，这种nil值字段就会被认为是不存在。cs2lua之前采用一个单独的字段表来记录，并把字段值nil用一个lightuserdata表示，然后在元方法里读写这个字段，并进行lightuserdata到nil的来回转换，这在性能与直观方面都不太好，现在cs2lua翻译时数据字段直接放到类或实例表里，然后在类上另外提供2张表（静态与实例字段表），用来记录当前类存在哪些字段。

8、定制转换器，cs2lua使用一个dsl脚本generator.dsl来定制部分函数的翻译，对于委托到lualib的函数，这个脚本可以根据函数参数的值来选择是否要采用特殊的翻译。除脚本定制外，还通过cs2dsl.dsl配置来指明特定类的indexer方法是否可以翻译为数组操作并指明是否需要对索引+1，这里也可以配置为特定函数做代码插桩。此外，还有一个配置rewriter.dsl，可以配置允许的泛型或不允许类、方法等。

9、在被翻译的C#代码里，通过引用Cs2DslUtility.dll，可以添加属性标记，用来指明忽略指定类或者指定某个方法翻译到手写的某个lua模块的方法，也可以指明require指定的lua模块等。

## 【lualib.lua】

*** cs2lua的实现假设C#导出给lua的API都采用slua。

Cs2Lua.exe负责按照c#语意选择合适的lua语法来实现对应语义，由于c#语言比lua复杂很多，在语言基础设施上很多是没法一一对应的，所以我们用lualib.lua来构建无法直接在lua语法层面简单实现的c#语义。主要包括：

1、基本运算

lua的运算符比c#少了很多，多出来的c#运算，有一些cs2lua经过语法变换对应到lua语句，比如复合赋值等；有一些cs2lua直接放弃，比如指针相关的操作；另一些则约定由lualib.lua提供一个对应的lua函数来实现，比如称位操作、位操作、条件表达式等。

2、对象语义

c#里的对象在lua里一般通过table+metatable来表示，与设计c#的对象运行时机制一样，我们需要在lua设计一套类似c#对象语义的运行时设施，这种机制也在lualib.lua里实现，cs2lua负责提供素材，比如method、property、field、event、indexer等对象的组成部分，组装成一个对象的工作则在lualib.lua里完成。

cs2lua将对象分类为被cs2lua转换的c#代码本身定义的对象与外部由slua导入的c#对象2大类，每类又分为普通对象、IList、IDictionary、ICollection这几种。

3、外部操作符重载处理

c#里的操作符重载比lua元表的操作符函数多，为了完全支持这些操作符函数的多个重载版本，cs2lua去掉了除__gc与__tostring之外的其它元方法，由lua直接调c#的相应重载操作符函数（有多个重载版本的会换名，同时这些操作符函数修改为静态方法），这个也放在lualib.lua里处理。

4、delegate的实现

cs2lua在转换delegate时委托到几个lua函数处理，这些函数在lualib.lua里实现，对被cs2lua转换的c#代码里定义的委托与slua导入的委托采用不同的函数，实现机制也不太相同。

5、外部indexer的实现

这块主要为了与slua的机制配合，放到lualib.lua里实现。

6、[]成员访问操作的实现

这个是预留，在语法上，对于数组访问[]与indexer已经分别独立处理，目前来看没发现其它种类的[]操作，但仍然预留了实现函数在lualib.lua里，由于这块不清楚对应的c#特性是什么，内部与外部实现都在lualib.lua里。

7、generic集合类型

cs2lua转换出的lua代码只使用lua的基础类型（不含string）与数组，其它类型假定都是经由slua导入。

由于lua不能直接对应generic语义，slua在导出c#类时要求导出的类必须是具体类，为了保证cs2lua在转换前后类名一致，所有generic类的实例类在导出时都需要进行一次继承，以保证导出的类在c#代码与lua代码里名字相同，比如导出List<int>，我们需要命名为IntList：

public class IntList : List<int>

{}

之后再由slua导出，之后在c#里就需要使用IntList而不是List<int>，这样才能保证转换出的lua代码能正确访问导出的类。

对于slua导入的API，这个约定没有问题，但被cs2lua转换的c#代码里也会有很频繁的需求使用常见的集合类型，因为被cs2lua转换的c#类转换后就是lua的table，天然可以支持动态类型，从这一角度出发，我们认为在被cs2lua转换的c#代码里使用的集合对象可以考虑转换为lua的table，借助table的元表机制，我们可以实现与c#里的集合对象相同的操作方法，这些代码都需要lua实现，所以放在lualib.lua里。

*** 需要注意的是，List<T>这类直接在被cs2lua转换的c#代码里使用的generic集合对象，由于转换为lua的table，不能作为参数传递给slua（除非修改slua的代码进行识别并转换，目前不采用这种思路）



## 【为什么不再支持各种lua的c#运行时？】

1、cs2lua需要对lua的c#封装进行较大修改，目前是基于slua的源码修改的，不能单独使用各类lua的c#运行时实现（比较大的修改是继承与重载方法的匹配机制）。

2、现在看来，cs2lua与lua的c#运行时在目标上有很大差异，手写lua更多是支持lua语言的特性，然后只需要允许c#提供lua api即可。自动翻译的lua实际上是使用lua来模拟c#语言的特性，此时需要更多向c#的习惯靠拢，而几乎所有lua的c#运行时机制在支持C#语言特性上都是残缺甚至很多特性都是不完备的。

3、尽管cs2lua已经限制了c#的很多语法，为了更完备的支持已经支持的c#语言特性（大概是c# 7.0除去本地方法与模式匹配语法，c#的语法糖对性能影响很大，放弃了很多语法糖特性），需要对lua的c#运行时进行大量修改以支持以c#开发时可以自由书写代码。



## 【为什么没有先构造一个AST再转换为lua？】

1、最早是直接一步翻译到lua的，语法制导翻译就是这个意思，我们实际上是基于C#的AST翻译到lua，早期由于此工作的实验性质，直接翻译到代码更加直观与快捷。

2、翻译到lua AST本身和翻译到lua代码在工作上差不多，并不因为有AST这一层能带来优势，除非这个AST是专为翻译设计，而不是lua语言的AST。

3、专为翻译设计的AST相比直接翻译到代码的好处是，翻译到代码本质上是一个流式输出的过程，所以每一步翻译都需要即时知晓翻译所需的全部信息，这是cs2lua有许多分析helper类的原因（用于提前遍历c#语法树来搜集翻译所需信息）。使用专为翻译设计的AST可以逐渐补全翻译所需信息（因为这时候不是流式输出了，这其实和解析xml的2套接口的差异类似，一套是流式读取接口，一套是文档加载接口），不过，这也只是部分缓解这个情况，比如创建AST实例时如果还缺少结构性信息，那么AST的构造就会比较困难。

4、从cs2lua编写的情况看，利用各种helper来提前遍历搜集翻译信息对性能的影响相对较小，所以感觉这样问题不大。

5、现在看翻译其实是分2个阶段完成的，第一阶段是C#的去语法糖，也就是把复杂的C#语法简化，先得到一个简化的中间语言，第二阶段则是把这个简化的中间语言转换为lua。这个中间语言采用了DSL（https://github.com/dreamanlan/MetaDSL ）来表示，当然，翻译到DSL依然还是采用直接到代码的方式。不过，其实DSL是有一套类似AST表示的数据结构的，不过，这些表示我认为更像是DSL的语义层面的数据（按我个人使用DSL的经验，读取源码后得到语法语义数据比较自然，但仅为了输出代码先构建语法语义数据，再输出代码，其实并不比直接输出代码直观。内存数据结构的主要作用还是在于有需要基于它们的加工的时候）。

6、定义一个通用的中间语言层的好处是，我们通过写不同的转换器，可以翻译到不同的目标语言。我在另一个工程里实验了翻译到lua与javascript，确实可以共用第一阶段的工作。（https://github.com/dreamanlan/Cs2Dsl ）

7、我觉得翻译最核心的地方还是在于正确性而不是使用了多少层间接层次。所以我的策略是在语法单位层面上寻找一个等价变换，保证翻译后的语法在语义上与翻译前是等价的，事实证明，这些等价变换是翻译的有效保证，即便这样可能会有一定的性能与可读性的损失（理论上是可以在翻译后进一步解决的，但不宜作为翻译时的目标）。



## 【cs2lua实现上的两大部分】
cs2lua从一开始就是为unity3d翻译lua的，所以从一开始就是把lua作为一种嵌入语言使用。以嵌入语言来说，必须要分清的是语言与环境（也就是提供给脚本的API）。类似的，对翻译到lua来说，首先必须要分清的就是哪些是翻译到lua的代码，哪些是作为API提供给lua的代码。这两部分在使用上是有差异的，比如，作为API提供给lua的代码，就会有许多限制，不能使用泛型，重载的多个函数可能要用一个API提供，那重载的解决策略就是一个问题。再比如重载函数里同时有带params参数的函数与不带params参数的函数等。

1、作为API提供给lua的C#代码，在翻译出的lua代码里使用时，对每一个重载版本会生成一个换过名的导出函数，这样可以精确匹配调用的方法版本（原版本的slua的重载机制有很多无法正确区分重载函数的限制）。如果调用的是翻译出的lua函数，翻译时我们也采用函数换名来区分重载版本（换名规则与API略有不同）。换名机制与C++里函数重载的换名类似。

2、作为API提供给lua的c#代码，不能暴露Generic类，我们需要将Generic类继承成类型参数实例化后的普通类版本。但在翻译出lua的代码里，我们是可以定义与使用Generic类的，此时每个泛型实例类都会单独生成一份代码，这也与C++的模板机制一致（我尝试过用一个类来模拟C#的运行时泛型类，但发觉有不少情形处理不了，而C++的模板类实例化的实现是C#机制的超集，可以保证正确性）。当然因此也引入了一个限制，就是泛型类的函数重载，换名时为了保证各实例化的类是一致的，我采用了泛型类型参数名来构造函数签名，这会导致基于泛型参数的C#重载翻译出来是同名的函数（这种情形实际使用中很少，所以约定修改C#代码来保证这样的函数名称不冲突）。

3、从cs2lua使用的情况看，翻译部分的修改相对其实较少。但适配API是个很麻烦的问题，这导致我放弃直接使用lua的C#运行时，而转而基于slua进行比较大的修改来支持翻译结果更贴近C#语言。这也是lualib.lua这个lua库里除了模拟c#对象外做的主要的工作，由于适配API真的是非常复杂，所以我在翻译时对于API的使用大多采取了调lualib里的函数来处理，这在翻译结果的代码里看起来是不太直观的，但这也是为了确保正确性。

4、lualib.lua也是cs2lua里一个可能永远都未完成的部分，或者说是一个需要根据不同项目习惯进行定制的部分。

5、cs2lua还使用了几个dsl配置文件来定制部分翻译与类型检查，主要也是为了适配API，c#语言相对lua来说还是太复杂，特性太丰富了。比如说容器类的索引是否需要在翻译时+1这类问题，或者是哪些类是不允许在翻译到lua的代码里使用的或是允许使用的等等。
