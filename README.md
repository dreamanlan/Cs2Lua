# Cs2Lua
CSharp代码转lua，适用于使用lua实现热更新而又想有一个强类型检查的语言的场合。

PDF文档：[Cs2Lua](https://github.com/dreamanlan/Cs2Lua/raw/master/Cs2Lua.pdf "Cs2Lua")

文档pptx压缩zip：[Cs2Lua pptx](https://github.com/dreamanlan/Cs2Lua/raw/master/Cs2Lua.zip "Cs2Lua pptx")



## 【示例链接】

https://github.com/dreamanlan/Cs2Lua/tree/master/Test



## 【用法】
https://github.com/dreamanlan/Cs2Lua/blob/master/USAGE.md



## 【设计与实现原理】
https://github.com/dreamanlan/Cs2Lua/blob/master/DESIGN.md



## 【最新进展】

【2021-04-03】 if语句函数对象优化，条件操作符表达式拆分成函数，lualib增加lua字符串操作（避免频繁构造c# String）

【2021-02-26】 对象模型调整，实现层基于class来定位方法（避免元表按继承层次查找，编译时绑定，虚方法转到obj上调用，类似虚函数表效果，运行时绑定），接口层基于obj来调用，使用常见的对象继承结构（基类方法表作为子类元表__index）。修正coroutine的crash隐患，修复因升级roslyn引入的隐式转换未识别的问题（roslyn新版本调整了在各语法层次获取IOperation的机制，以前能取到的现在取到的是null或类型和以前不一样了）。值类型局部变量如果被lambda函数捕获的，在函数退出时不回收。

【2021-01-30】 去掉InvokeToLuaLib属性，改在rewriter.dsl里配置函数调用翻译为哪个lualib的调用，这样便于处理外部dll里的调用。

【2021-01-16】 值类型参数转换从函数入口处处理改为在调用时处理；补全值类型数组的读写处理arraygetstruct/arraysetstruct与外部indexer的元素值读取getexternstaticindexerstruct/getexterninstanceindexerstruct处理。

【2021-01-13】 基于数据流与控制流分析结果对try与using代码块部分拆分独立函数，减少GC；条件表达式给对象成员赋值改写为if-else语句形式，避免使用函数对象产生GC。

【2021-01-10】 对涉及值类型处理的方法拆分为2个，将函数信息放到外层方法，然后通过xpcall调用内层方法，以保证在异常时函数信息处理的进入/退出也是配对的。这个版本应该是比较完善与正确的版本了。

【2021-01-08】 值类型返回值的内存池处理完善，返回值在返回前从当前函数信息移动到调用方的函数信息记录里，以保证返回值在使用后再回收重用。

【2021-01-07】 Slua迭代器函数支持未明确实现IEnumerable接口但提供了功能的对象的迭代。

【2021-01-04】 Array与List的foreach语句翻译为普通for循环，减少迭代器GC。

【2020-12-31】 Roslyn升级到15.9，支持到C#7.3的最后一个版本。



## 【调试lua】

可以使用LuaStudio进行lua调试，但对于比较复杂的工程，调试实在是非常慢。



## 【为什么不再支持各种lua的c#运行时？】

1、cs2lua需要对lua的c#封装进行较大修改，目前是基于slua的源码修改的，不能单独使用各类lua的c#运行时实现（比较大的修改是继承与重载方法的匹配机制）。

2、现在看来，cs2lua与lua的c#运行时在目标上有很大差异，手写lua更多是支持lua语言的特性，然后只需要允许c#提供lua api即可。自动翻译的lua实际上是使用lua来模拟c#语言的特性，此时需要更多向c#的习惯靠拢，而几乎所有lua的c#运行时机制在支持C#语言特性上都是残缺甚至很多特性都是不完备的。

3、尽管cs2lua已经限制了c#的很多语法，为了更完备的支持已经支持的c#语言特性（大概是c# 7.0除去本地方法与模式匹配语法，c#的语法糖对性能影响很大，放弃了很多语法糖特性），需要对lua的c#运行时进行大量修改以支持以c#开发时可以自由书写代码。



## 【为什么没有先构造一个AST再转换为lua？】

1、最早是直接一步翻译到lua的，语法制导翻译就是这个意思，我们实际上是基于C#的AST翻译到lua，早期由于此工作的实验性质，直接翻译到代码更加直观与快捷。

2、翻译到lua AST本身和翻译到lua代码在工作上差不多，并不因为有AST这一层能带来优势，除非这个AST是专为翻译设计，而不是lua语言的AST。

3、专为翻译设计的AST相比直接翻译到代码的好处是，翻译到代码本质上是一个流式输出的过程，所以每一步翻译都需要即时知晓翻译所需的全部信息，这是cs2lua有许多分析helper类的原因（用于提前遍历c#语法树来搜集翻译所需信息）。使用专为翻译设计的AST可以逐渐补全翻译所需信息（因为这时候不是流式输出了，这其实和解析xml的2套接口的差异类似，一套是流式读取接口，一套是文档加载接口），不过，这也只是部分缓解这个情况，比如创建AST实例时如果还缺少结构性信息，那么AST的构造就会比较困难。

4、从cs2lua编写的情况看，利用各种helper来提前遍历搜集翻译信息对性能的影响相对较小，所以感觉这样问题不大。

5、现在看翻译其实是分2个阶段完成的，第一阶段是C#的去语法糖，也就是把复杂的C#语法简化，先得到一个简化的中间语言，第二阶段则是把这个简化的中间语言转换为lua。这个中间语言采用了DSL（https://github.com/dreamanlan/MetaDSL ）来表示，当然，翻译到DSL依然还是采用直接到代码的方式。不过，其实DSL是有一套类似AST表示的数据结构的，不过，这些表示我认为更像是DSL的语义层面的数据。（按我个人使用DSL的经验，读取源码后得到语法语义数据比较自然，但仅为了输出代码先构建语法语义数据，再输出代码，其实并不比直接输出代码直观。内存数据结构的主要作用还是在于有需要基于它们的加工的时候）

6、定义一个通用的中间语言层的好处是，我们通过写不同的转换器，可以翻译到不同的目标语言。我在另一个工程里实验了翻译到lua与javascript，确实可以共用第一阶段的工作。（https://github.com/dreamanlan/Cs2Dsl ）

7、我觉得翻译最核心的地方还是在于正确性而不是使用了多少层间接层次。所以我的策略是在语法单位层面上寻找一个等价变换，保证翻译后的语法在语义上与翻译前是等价的，事实证明，这些等价变换是翻译的有效保证，即便这样可能会有一定的性能与可读性的损失（理论上是可以在翻译后进一步解决的，但不宜作为翻译时的目标）。

## 【一个容易翻错的例子（防止误调整计算顺序的备忘）】

C#表达式内嵌的++/--运算、带out/ref参数的函数，在翻译时要特别注意求值顺序，比如下例中的fv的计算，表达式的各项都是使用kk或者修改kk的，这让表达式各项之
间形成依赖，如果不严格按照这个顺序计算，结果就会错误，cs2lua采取匿名函数来处理++/--运算与out/ref参数，就是为了保证在语义上与c#原表达式等价。


    using System;
    using System.Collections.Generic;

    public static class Program
    {
        public static void Main()
        {
            int kk = 0;
            int fv = kk + kk++ + ++kk + Transform(out kk) + After(ref kk);
        }
        public static int Transform(out int v)
        {
            v = 123;
            return v;
        }
        public static int After(ref int v)
        {
            ++v;
            return v;
        }    
    }
