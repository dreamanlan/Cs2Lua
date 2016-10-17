using System;
using System.IO;

//local write = io.write;

class Mandelbrot
{
    public static void Exec()
    {
        int width = 50;
        int height = width;
        int maxiter = 50;
        double limit = 4.0;
#if __LUA__
        write("P4\n", width, " ", height, "\n");
#endif
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
#if __LUA__
                    write("*");
#endif
                } else {
#if __LUA__
                    write(" ");
#endif
                }
            }
#if __LUA__
            print();
#endif
        }
    }
}

//Mandelbrot.Exec();