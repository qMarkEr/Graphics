namespace GEngine
{

    // class Engine
    // {
    //     private int w;
    //     private string grad = ".-~+=#$@";
    //     private int h;
    //     private double k1;
    //     private const int k2 = 20;
    //     private double[,] zBuffer;
    //     private char[,] output;
    //     private float aspect;
    //
    //
    //
    //     public Engine()
    //     {
    //         w = Console.BufferWidth;
    //         h = Console.BufferHeight;
    //         aspect = (float)w / h * 0.5f;
    //         zBuffer = new double[w, h];
    //         output = new char[w, h];
    //         k1 = w / 2 * 5 / k2;
    //         for (int i = 0; i < w; i++)
    //         {
    //             for (int j = 0; j < h; j++)
    //             {
    //                 zBuffer[i, j] = 0;
    //                 output[i, j] = ' ';
    //             }
    //         }
    //     }
    //
    //     public void Render()
    //     {
    //         fill3();
    //         Console.Clear();
    //         for (int i = 0; i < h; i++)
    //         {
    //             for (int j = 0; j < w; j++)
    //             {
    //                 Console.Write(output[j, i]);
    //             }
    //
    //             Console.WriteLine();
    //         }
    //
    //         Console.WriteLine();
    //     }
    //
    //
    //
    //
    //     private void fill2()
    //     {
    //         int L = 10;
    //         double k2 = Math.Min(h, w) / 2;
    //         // double k2 = h * 0.3;
    //         for (double i = 0; i < L; i += 0.1)
    //         {
    //             for (double j = 0; j < L; j += 0.1)
    //             {
    //                 double x = (i) * aspect;
    //                 double y = j - L / 2;
    //                 double z = 10 + x * 0.5;
    //                 double _z = 1 / z;
    //                 int x1 = Convert.ToInt32(w / 2 + x * k2 * _z);
    //                 int y1 = Convert.ToInt32(h / 2 - y * k2 * _z);
    //                 vector N = new vector(x, y, z);
    //                 vector Norm = new vector(x / N.len, y / N.len, z / N.len);
    //                 vector Norm2 = new vector(2, -10, -5);
    //                 N.x = (Norm.y * Norm2.z - Norm2.y * Norm.z);
    //                 N.y = Norm.x * Norm2.z - Norm2.x * Norm.z;
    //                 N.z = Norm.x * Norm2.y - Norm2.x * Norm.y;
    //                 double Lt = N.x / N.len * 10 + N.y;
    //                 int index = Convert.ToInt32(Lt * 0.74);
    //                 if (_z > zBuffer[x1, y1])
    //                 {
    //                     zBuffer[x1, y1] = _z;
    //                     //output[x1, y1] = grad[crop(7, 0, index)];
    //                 }
    //             }
    //         }
    //     }
    //
    //
    // }


    class implementation
    {
        public static void Main(string[] args)
        { 
            Sphere s = new Sphere(10, 0, 0, -30, 1, 0, 1, 70);
            Plane p = new Plane(10, -30, 0, 30, 0, 1, 1, 100);
            Plane p1 = new Plane(10, 10.3, 0, 15, 0, 1, 1, 100); 
            p.Render(Math.PI / 3);
            p1.Render(-Math.PI / 6);
           for (int i = 0; i < Console.BufferHeight; i++)
           {
               for (int j = 0; j < Console.BufferWidth; j++)
               {
                   
                   if (p1.output[j, i] != ' ')
                   {
                       Console.Write(p1.output[j, i]);
                       continue;
                   }
                   Console.Write(p.output[j, i]);
               }
               Console.WriteLine();
           }
        }
    }
}