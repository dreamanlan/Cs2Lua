using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using RoslynTool.CsToDsl;
using System.Diagnostics;

namespace RoslynTool
{
    partial class Program
    {
        static void Main(string[] args)
        {
            try {
                string file = "test.cs";
                string outputDir = string.Empty;
                string outputExt = "txt";
                List<string> macros = new List<string>();
                List<string> undefMacros = new List<string>();
                List<string> ignoredPath = new List<string>();
                List<string> externPath = new List<string>();
                List<string> internPath = new List<string>();
                Dictionary<string, string> refByNames = new Dictionary<string, string>();
                Dictionary<string, string> refByPaths = new Dictionary<string, string>();
                bool enableInherit = false;
                bool enableLinq = false;
                bool outputResult = false;
                bool parallel = false;
				
                var assems = AppDomain.CurrentDomain.GetAssemblies();
                foreach (var assem in assems) {
                    Console.WriteLine("Assembly:{0} CodeBase:{1} Location:{2} Version:{3} global cache:{4}", assem.FullName, assem.CodeBase, assem.Location, assem.ImageRuntimeVersion, assem.GlobalAssemblyCache);
                }
                if (args.Length > 0) {
                    for (int i = 0; i < args.Length; ++i) {
                        if (0 == string.Compare(args[i], "-ext", true)) {
                            if (i < args.Length - 1) {
                                string arg = args[i + 1];
                                if (!arg.StartsWith("-")) {
                                    outputExt = arg;
                                    ++i;
                                }
                            }
                        }
                        else if (0 == string.Compare(args[i], "-out", true)) {
                            if (i < args.Length - 1) {
                                string arg = args[i + 1];
                                if (!arg.StartsWith("-")) {
                                    outputDir = arg;
                                    ++i;
                                }
                            }
                        }
                        else if (0 == string.Compare(args[i], "-d", true)) {
                            if (i < args.Length - 1) {
                                string arg = args[i + 1];
                                if (!arg.StartsWith("-")) {
                                    macros.Add(arg);
                                    ++i;
                                }
                            }
                        }
                        else if (0 == string.Compare(args[i], "-u", true)) {
                            if (i < args.Length - 1) {
                                string arg = args[i + 1];
                                if (!arg.StartsWith("-")) {
                                    undefMacros.Add(arg);
                                    ++i;
                                }
                            }
                        }
                        else if (0 == string.Compare(args[i], "-ignorepath", true)) {
                            if (i < args.Length - 1) {
                                string arg = args[i + 1];
                                if (!arg.StartsWith("-")) {
                                    ignoredPath.Add(arg);
                                    ++i;
                                }
                            }
                        }
                        else if (0 == string.Compare(args[i], "-externpath", true)) {
                            if (i < args.Length - 1) {
                                string arg = args[i + 1];
                                if (!arg.StartsWith("-")) {
                                    externPath.Add(arg);
                                    ++i;
                                }
                            }
                        }
                        else if (0 == string.Compare(args[i], "-internpath", true)) {
                            if (i < args.Length - 1) {
                                string arg = args[i + 1];
                                if (!arg.StartsWith("-")) {
                                    internPath.Add(arg);
                                    ++i;
                                }
                            }
                        }
                        else if (0 == string.Compare(args[i], "-systemdllpath", true)) {
                            if (i < args.Length - 1) {
                                string arg = args[i + 1];
                                if (!arg.StartsWith("-")) {
                                    SymbolTable.SystemDllPath = arg;
                                    ++i;
                                }
                            }
                        }
                        else if (0 == string.Compare(args[i], "-src", true)) {
                            if (i < args.Length - 1) {
                                string arg = args[i + 1];
                                if (!arg.StartsWith("-")) {
                                    file = arg;
                                    if (!File.Exists(file)) {
                                        Console.WriteLine("file path not found ! {0}", file);
                                    }
                                    ++i;
                                }
                            }
                        }
                        else if (0 == string.Compare(args[i], "-enableinherit", true)) {
                            enableInherit = true;
                        }
                        else if (0 == string.Compare(args[i], "-enablelinq", true)) {
                            enableLinq = true;
                        }
                        else if (0 == string.Compare(args[i], "-outputresult", true)) {
                            outputResult = true;
                        }
                        else if (0 == string.Compare(args[i], "-parallel", true)) {
                            parallel = true;
                        }
                        else if (0 == string.Compare(args[i], "-noautorequire", true)) {
                            SymbolTable.NoAutoRequire = true;
                        }
                        else if (0 == string.Compare(args[i], "-componentbystring", true)) {
                            SymbolTable.DslComponentByString = true;
                        }
                        else if (0 == string.Compare(args[i], "-usearraygetset", true)) {
                            SymbolTable.UseArrayGetSet = true;
                        }
                        else if (0 == string.Compare(args[i], "-enabletranslationcheck", true)) {
                            SymbolTable.EnableTranslationCheck = true;
                        }
                        else if (0 == string.Compare(args[i], "-refbyname", true)) {
                            string name = string.Empty, alias = "global";
                            if (i < args.Length - 1) {
                                string arg = args[i + 1];
                                if (!arg.StartsWith("-")) {
                                    name = arg;
                                    ++i;
                                }
                                else {
                                    continue;
                                }
                            }
                            else {
                                continue;
                            }
                            if (i < args.Length - 1) {
                                string arg = args[i + 1];
                                if (!arg.StartsWith("-")) {
                                    alias = arg;
                                    ++i;
                                }
                            }
                            if (!refByNames.ContainsKey(name)) {
                                refByNames.Add(name, alias);
                            }
                            else {
                                Console.WriteLine("refbyname duplicate, ignored ! {0}={1}", name, alias);
                            }
                        }
                        else if (0 == string.Compare(args[i], "-refbypath", true)) {
                            string path = string.Empty, alias = "global";
                            if (i < args.Length - 1) {
                                string arg = args[i + 1];
                                if (!arg.StartsWith("-")) {
                                    path = arg;
                                    ++i;
                                }
                                else {
                                    continue;
                                }
                            }
                            else {
                                continue;
                            }
                            if (i < args.Length - 1) {
                                string arg = args[i + 1];
                                if (!arg.StartsWith("-")) {
                                    alias = arg;
                                    ++i;
                                }
                            }
                            if (!File.Exists(path)) {
                                Console.WriteLine("refbypath path not found ! {0}={1}", path, alias);
                            }
                            else {
                                if (!refByPaths.ContainsKey(path)) {
                                    refByPaths.Add(path, alias);
                                }
                                else {
                                    Console.WriteLine("refbypath duplicate, ignored ! {0}={1}", path, alias);
                                }
                            }
                        }
                        else {
                            file = args[i];
                            if (!File.Exists(file)) {
                                Console.WriteLine("file path not found ! {0}", file);
                            }
                            break;
                        }
                    }
                }
                else {
                    Console.WriteLine("Continue? [y]");
                    var keyInfo = Console.ReadKey();
                    if (keyInfo.KeyChar != 'y' && keyInfo.KeyChar != 'Y' && keyInfo.Key != ConsoleKey.Enter) {
                        Environment.Exit(0);
                        return;
                    }

                    Console.WriteLine("[Usage]:Cs2Lua [-out dir] [-ext fileext] [-enableinherit] [-enablelinq] [-outputresult] [-noautorequire] [-luacomponentbystring] [-usearraygetset] [-enabletranslationcheck] [-d macro] [-u macro] [-externpath path] [-ignorepath path] [-refbyname dllname alias] [-refbypath dllpath alias] [-systemdllpath dllpath] [-src] csfile|csprojfile");
                    Console.WriteLine("\twhere:");
                    Console.WriteLine("\t\tfileext = file externsion, default is txt for unity3d, maybe lua for other usage.");
                    Console.WriteLine("\t\tmacro = c# macro define, used in your csharp code #if/#elif/#else/#endif etc.");
                    Console.WriteLine("\t\tinternpath = only c# source file path in the csproj as intern class, only these classes translate to lua.");
                    Console.WriteLine("\t\texternpath = mark c# source file path in the csproj as extern class (API), these classes doesn't translate to lua.");
                    Console.WriteLine("\t\tignorepath = ignore c# source file path in the csproj, these classes doesn't translate to lua (need translate them by hand, cs2dsl use \"require 'cs2lua_custom';\" resolve xref).");
                    Console.WriteLine("\t\tdllname = dotnet system assembly name, referenced by your csharp code.");
                    Console.WriteLine("\t\tdllpath = dotnet assembly path, referenced by your csharp code.");
                    Console.WriteLine("\t\talias = global for default or some dll toplevel namespace alias, used in your csharp code such as 'extern alias ui;'.");
                    Console.WriteLine();
                    if (File.Exists(file)) {
                        Console.WriteLine("now will process test csharp code test.cs in current directory ...");
                        Console.WriteLine();
                    }                    
                }
                if (File.Exists(file)) {
                    var stopwatch1 = Stopwatch.StartNew();
                    var result = (int)CsToDslProcessor.Process(file, macros, undefMacros, ignoredPath, externPath, internPath, refByNames, refByPaths, enableInherit, enableLinq, outputResult, parallel);
                    stopwatch1.Stop();
                    Console.WriteLine("CsToDsl consume time: {0}s", stopwatch1.Elapsed.TotalSeconds);
                    var stopwatch2 = Stopwatch.StartNew();
                    Generator.LuaGenerator.Generate(Path.GetDirectoryName(file), outputDir, outputExt, parallel);
                    stopwatch2.Stop();
                    Console.WriteLine("LuaGenerator consume time: {0}s", stopwatch2.Elapsed.TotalSeconds);
                    System.Threading.Thread.Sleep(1000);
                    Environment.Exit(result);
                }
                else {
                    Environment.Exit((int)ExitCode.FileNotFound);
                }
            }
            catch (Exception ex) {
                Console.WriteLine("exception:{0}", ex.Message);
                Console.WriteLine("{0}", ex.StackTrace);
                while (null != ex.InnerException) {
                    ex = ex.InnerException;

                    Console.WriteLine("inner exception:{0}", ex.Message);
                    Console.WriteLine("{0}", ex.StackTrace);
                }
                Environment.Exit((int)ExitCode.Exception);
            }
        }
    }
}
