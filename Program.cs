using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using RoslynTool.CsToLua;

namespace RoslynTool
{
    partial class Program
    {
        static void Main(string[] args)
        {
            string file = "test.cs";
            string outputExt = "txt";
            List<string> macros = new List<string>();
            Dictionary<string, string> refByNames = new Dictionary<string, string>();
            Dictionary<string, string> refByPaths = new Dictionary<string, string>();
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
                    } else if (0 == string.Compare(args[i], "-d", true)) {
                        if (i < args.Length - 1) {
                            string arg = args[i + 1];
                            if (!arg.StartsWith("-")) {
                                macros.Add(arg);
                                ++i;
                            }
                        }
                    } else if (0 == string.Compare(args[i], "-refbyname", true)) {
                        string name = string.Empty, alias = "global";
                        if (i < args.Length - 1) {
                            string arg = args[i + 1];
                            if (!arg.StartsWith("-")) {
                                name = arg;
                                ++i;
                            } else {
                                continue;
                            }
                        } else {
                            continue;
                        }
                        if (i < args.Length - 1) {
                            string arg = args[i + 1];
                            if (!arg.StartsWith("-")) {
                                alias = arg;
                                ++i;
                            } else {
                                continue;
                            }
                        }
                        if (!refByNames.ContainsKey(name)) {
                            refByNames.Add(name, alias);
                        } else {
                            Console.WriteLine("refbyname duplicate, ignored ! {0}={1}", name, alias);
                        }
                    } else if (0 == string.Compare(args[i], "-refbypath", true)) {
                        string path = string.Empty, alias = "global";
                        if (i < args.Length - 1) {
                            string arg = args[i + 1];
                            if (!arg.StartsWith("-")) {
                                path = arg;
                                ++i;
                            } else {
                                continue;
                            }
                        } else {
                            continue;
                        }
                        if (i < args.Length - 1) {
                            string arg = args[i + 1];
                            if (!arg.StartsWith("-")) {
                                alias = arg;
                                ++i;
                            } else {
                                continue;
                            }
                        }
                        if (!File.Exists(path)) {
                            Console.WriteLine("refbypath path not found ! {0}={1}", path, alias);
                        } else {
                            if (!refByPaths.ContainsKey(path)) {
                                refByPaths.Add(path, alias);
                            } else {
                                Console.WriteLine("refbypath duplicate, ignored ! {0}={1}", path, alias);
                            }
                        }
                    } else {
                        file = args[i];
                        if (!File.Exists(file)) {
                            Console.WriteLine("file path not found ! {0}", file);
                        }
                        break;
                    }
                }
            } else {
                Console.WriteLine("[Usage]:Cs2Lua [-ext fileext] [-d macro] [-refbyname dllname alias] [-refbypath dllpath alias] csfile|csprojfile");
                Console.WriteLine("\twhere:");
                Console.WriteLine("\t\tfileext = file externsion, default is txt for unity3d, maybe lua for other usage.");
                Console.WriteLine("\t\tmacro = c# macro define, used in your csharp code #if/#elif/#else/#endif etc.");
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
                CsToLuaProcessor.Process(file, outputExt, macros, refByNames, refByPaths);
            }
            //Mandelbrot.Exec();
        }
    }
}

class Mandelbrot
{
    public static void Exec()
    {

        int[] abc = new int[256];
        int[] def = new int[] { 1, 2, 3, 4, 5 };
        int[][][] g0 = new int[3][][];
        int[, ,] h0 = new int[3, 5, 7];
        int[][] g = new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 } };
        int[,] h = new int[,] { { 1, 2 }, { 3, 4 } };

        var arr = new int[] { 1,2,3,4 };

        int width = 50;
        int height = width;
        int maxiter = 50;
        double limit = 4.0;
        
        Console.WriteLine("P4");
        Console.WriteLine("{0} {1}", width, height);
        
        for (int y = 0; y < height; y++) {
            double Ci = 2.0 * y / height - 1.0;
            //Console.WriteLine("{0:F4}", Ci);
            for (int x = 0; x < width; x++) {
                double Zr = 0.0;
                double Zi = 0.0;
                double Cr = 2.0 * x / width - 1.5;
                int i = maxiter;
                //Console.WriteLine("{0:F4}", Cr);
                bool isInside = true;
                do {
                    double Tr = Zr * Zr - Zi * Zi + Cr;
                    Zi = 2.0 * Zr * Zi + Ci;
                    Zr = Tr;
                    //Console.WriteLine("{0} {1:F4} {2:F4} {3:F4}", i, Zr, Zi, Zr * Zr + Zi * Zi);
                    if (Zr * Zr + Zi * Zi > limit) {
                        isInside = false;
                        break;
                    }
                } while (--i > 0);

                if (isInside) {
                    Console.Write('*');
                } else {
                    Console.Write(' ');
                }
            }
            Console.WriteLine();
        }
    }
}
