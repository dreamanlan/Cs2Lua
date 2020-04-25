# Cs2Lua
CSharp代码转lua，适用于使用lua实现热更新而又想有一个强类型检查的语言的场合

## 【示例链接】

https://github.com/dreamanlan/Cs2Lua/tree/master/Test



## 【用法】
https://github.com/dreamanlan/Cs2Lua/blob/master/USAGE.md



## 【设计与实现原理】
https://github.com/dreamanlan/Cs2Lua/blob/master/DESIGN.md



## 【调试lua】

可以使用LuaStudio进行lua调试，但对于比较复杂的工程，调试实在是非常慢。



## 【为什么不再支持各种lua的c#运行时？】

1、cs2lua需要对lua的c#封装进行较大修改，目前是基于slua的源码修改的，不能单独使用各类lua的c#运行时实现（比较大的修改是继承与重载方法的匹配机制）。

2、现在看来，cs2lua与lua的c#运行时在目标上有很大差异，手写lua更多是支持lua语言的特性，然后只需要允许c#提供lua api即可。自动翻译的lua实际上是使用lua来模拟c#语言的特性，此时需要更多向c#的习惯靠拢，而几乎所有lua的c#运行时机制在支持C#语言特性上都是残缺甚至很多特性都是不完备的。

3、尽管cs2lua已经限制了c#的很多语法，为了更完备的支持已经支持的c#语言特性（大概是c# 7.0除去本地方法与模式匹配语法，c#的语法糖对性能影响很大，放弃了很多语法糖特性），需要对lua的c#运行时进行大量修改以支持以c#开发时可以自由书写代码。
