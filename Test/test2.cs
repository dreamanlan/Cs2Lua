using System;
using System.IO;

//local write = io.write;

[Cs2Lua.Ignore]
class LuaConsole
{
    public static void Write(params object[] args)
    {
        for (int i = 0; i < args.Length; ++i) {
            var arg = args[i];
            System.Console.Write(arg);
            if (i < args.Length - 1) {
                System.Console.Write(", ");
            }
        }
    }
    public static void Print(params object[] args)
    {
        Write(args);
        System.Console.WriteLine();
    }
}

class Mandelbrot
{
    public static void Exec()
    {
        int width = 50;
        int height = width;
        int maxiter = 50;
        double limit = 4.0;

        LuaConsole.Write("P4\n", width, " ", height, "\n");

        for (int y = 0; y < height; y++) {
            double Ci = 2.0 * y / height - 1.0;

            for (int x = 0; x < width; x++) {
                double Zr = 0.0;
                double Zi = 0.0;
                double Cr = 2.0 * x / width - 1.5;
                int i = maxiter;

                bool isInside = true;
                do {
                    double Tr = Zr * Zr - Zi * Zi + Cr;
                    Zi = 2.0 * Zr * Zi + Ci;
                    Zr = Tr;
                    if (Zr * Zr + Zi * Zi > limit) {
                        isInside = false;
                        break;
                    }
                } while (--i > 0);

                if (isInside) {
                    LuaConsole.Write("*");
                } else {
                    LuaConsole.Write(" ");
                }
            }
            LuaConsole.Print();
        }
    }
}

//Mandelbrot.Exec();