namespace GEngine
{

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