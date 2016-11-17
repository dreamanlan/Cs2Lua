using UnityEngine;
using System.IO;

class Mandelbrot : IStartupPlugin
{
    public void Start(GameObject obj)
    {
        root = new GameObject("mandelbrot");
        Exec();
    }
    public void Call(string name, params object[] args)
    { }
    private void Exec()
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
                    DrawCube(x, y, width, height);
                }
            }
        }
    }
    private void DrawCube(int x, int y, int w, int h)
    {
        var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(x * r * scale / w, y * r * scale / h - 12, 0);
        cube.transform.SetParent(root.transform);

        var mat = cube.GetComponent<Renderer>().material;
        int ix = UnityEngine.Random.Range(0, colors.Length);
        mat.color = colors[ix];
    }

    private GameObject root = null;
    private Color[] colors = new Color[] { Color.red, Color.blue, Color.green, Color.cyan, Color.grey, Color.white, Color.yellow, Color.magenta, Color.black };
    private float r = 10;
    private float scale = 3.0f;
}

//Mandelbrot.Exec();