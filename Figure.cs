namespace GEngine;

public abstract class Figure
{
    protected int w;
    protected int h;
    protected double k1;
    protected string grad = " .-~+=#$@";
    protected double[,] zBuffer;
    public char[,] output;
    protected double aspect;
    protected vector lgt;
    protected double lgt_strength;

    protected Figure(double x, double y, double z, double st)
    {
        lgt_strength = st;
        double ln = Math.Sqrt(x * x + y * y + z * z);
        lgt = new vector(x / ln, y / ln, z / ln);
        w = Console.BufferWidth;
        h = Console.BufferHeight;
        zBuffer = new double[w, h];
        output = new char[w, h];
        aspect = (double) w / h * 0.5;
        for (int i = 0; i < w; i++)
        {
            for (int j = 0; j < h; j++)
            {
                zBuffer[i, j] = 0;
                output[i, j] = ' ';
            }
        }
    }

    protected abstract void fill(double k);
    public abstract void Render(double k);
    protected void Print()
    {
        Console.Clear();
        //Console.WriteLine("\x1b[H");
        for (int i = 0; i < h; i++)
        {
            for (int j = 0; j < w; j++)
            {
                Console.Write(output[j, i]);
            }
            
            Console.WriteLine();
        }
            
        Console.WriteLine();
    }

}