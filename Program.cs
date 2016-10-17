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
    class Program
    {
        static void Main(string[] args)
        {
            string file = "test.cs";
            if (args.Length > 0) {
                file = args[0];
            }
            CsToLuaProcessor.Process(file);
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
