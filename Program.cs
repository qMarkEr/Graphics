namespace GEngine
{

    class implementation
    {
        public static void Main(string[] args)
        {

            Plane p = new Plane(10, -30, 0, 30, 1, 0, 0, 50);
            Plane p1 = new Plane(10, 10.3, 0, 15, 1, 0, 0, 50);
            double x = 0, y = 0, z = -15, phi = 0, theta = 0, st = 70;
            while (true)
            {
                var w = Console.ReadKey().Key;
                System.Console.WriteLine(w);
                switch (w)
                {
                    case ConsoleKey.A:
                        x -= 2;
                        break;
                    case ConsoleKey.D:
                        x += 2;
                        break;
                    case ConsoleKey.W:
                        z += 2;
                        break;
                    case ConsoleKey.S:
                        z -= 2;
                        break;
                    case ConsoleKey.LeftArrow:
                        phi -= Math.PI / 12;
                        break;
                    case ConsoleKey.RightArrow:
                        phi += Math.PI / 12;
                        break;
                    case ConsoleKey.UpArrow:
                        theta -= Math.PI / 12;
                        break;
                    case ConsoleKey.DownArrow:
                        theta += Math.PI / 12;
                        break;
                    case ConsoleKey.Oem4:
                        st -= 5;
                        break;
                    case ConsoleKey.Oem6:
                        st += 5;
                        break;
                }
                Sphere s = new Sphere(5, -x * Math.Cos(phi) - z * Math.Sin(phi),
                -y * Math.Cos(theta) + Math.Sin(theta) * (x * Math.Sin(phi) - z * Math.Cos(phi)),
                Math.Sin(theta) * y - Math.Cos(theta) * (x * Math.Sin(phi) - z * Math.Cos(phi)),
                1, -1, 1, st);
                s.Render(0);
            }

            //p.Render(Math.PI / 3);
            //p1.Render(-Math.PI / 6);
            //    for (int i = 0; i < Console.BufferHeight; i++)
            //    {
            //        for (int j = 0; j < Console.BufferWidth; j++)
            //        {

            //            if (p1.output[j, i] != ' ')
            //            {
            //                Console.Write(p1.output[j, i]);
            //                continue;
            //            }
            //            Console.Write(p.output[j, i]);
            //        }
            //        Console.WriteLine();
            //    }
        }
    }
}