using System;
using System.Collections.Generic;

[Cs2Dsl.Ignore]
class JsConsole
{
    public static void Print(params object[] args)
    {
    }
}

class Mandelbrot
{
    public void Exec()
    {
        int width = 50;
        int height = width;
        int maxiter = 50;
        double limit = 4.0;

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
                    Output(x * 1.0f / width, y * 1.0f / height);
                }
            }
        }
    }
    private void Output(float x, float y)
    {
        JsConsole.Print(x, y);
    }

    private float r = 10;
    private float scale = 3.0f;
    private int[] datas = new int[] { 1, 2, 3, 4, 5, 6 };
    private Dictionary<int, int> dicts = new Dictionary<int, int> { { 1, 1 }, { 2, 2 }, { 3, 3 }, { 4, 4 }, { 5, 5 } };
    private Dictionary<int, int> dicts2 = new Dictionary<int, int>(128);

    public static void Test()
    {
        new Mandelbrot().Exec();
    }
}
