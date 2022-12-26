namespace GEngine;

public class Sphere : Figure
{
    private double R;
    private double x_, y_, z_;

    public Sphere(double R, double x1, double y1, double z1, double x, double y, double z, double st) : base(x, y, z, st)
    {
        this.R = R;
        x_ = -x1;
        y_ = -y1;
        z_ = -z1;

    }

    protected override void fill(double k)
    {
        
        for (double theta = - Math.PI / 2; theta < Math.PI / 2; theta += 0.02)
        {
            double cost = Math.Cos(theta);
            double sint = Math.Sin(theta);
            for (double phi = 0; phi < 2 * Math.PI; phi += 0.01)
            {
                double cosp = Math.Cos(phi);
                double sinp = Math.Sin(phi);
                
                double hcx = R * cost, hcy = R * sint; // half circle x and y
                vector obj = new vector((hcx * cosp + x_) * aspect, hcy + y_, hcx * sinp + z_);
                

                k1 = (3 * h / 2) / (Math.Sqrt(3) * obj.z);
                double _z = 1 / obj.z;
                
                int x1 = Nums<int>.crop(w-1, 0, Convert.ToInt32(w / 2 + k1 * obj.x));
                int y1 = Nums<int>.crop(h-1, 0, Convert.ToInt32(h / 2 - k1 * obj.y));
                vector Norm = obj.Normalize();

                vector l = new vector(lgt.x, -lgt.y , lgt.z);
                double L = Norm.dot(l);
                
                if (_z > zBuffer[x1, y1])
                {
                    int index = Convert.ToInt32(lgt_strength * L / obj.z * 2);
                    zBuffer[x1, y1] = _z;
                    output[x1, y1] = grad[Nums<int>.crop(8, 0, index)];
                }
                
            }
        }
    }

    public override void Render(double k)
    {

            fill(1);
            Print();
            //     for (int i = 0; i < w; i++)
            //     {
            //         for (int j = 0; j < h; j++)
            //         {
            //             zBuffer[i, j] = 0;
            //             output[i, j] = ' ';
            //         }
            //     }
            // }
            
        
    }
}