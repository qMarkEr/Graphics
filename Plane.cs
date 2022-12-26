namespace GEngine;

public class Plane : Figure
{
    private double L;
    private double x_, y_, z_;

    public Plane(double R, double x1, double y1, double z1, double x, double y, double z, double st) : base(x, y, z, st)
    {
        this.L = R;
        x_ = x1;
        y_ = y1;
        z_ = z1;
    }

    protected override void fill(double k)
    {
        for (double i = -L/2; i < L/2; i += 0.1)
        {
            for (double j = -L/2; j < L/2; j += 0.1)
            {
                
                vector obj = new vector((i * Math.Cos(k) + z_ * Math.Sin(k) + x_) * aspect,
                    j + y_,
                    -i * Math.Sin(k) + z_ * Math.Cos(k));

                
                double _z = 1 / obj.z;
                k1 = (3 * h / 2) / (Math.Sqrt(3) * obj.z);
                int x1 = Nums<int>.crop(w-1, 0, Convert.ToInt32(w / 2 + k1 * obj.x));
                int y1 = Nums<int>.crop(h-1, 0, Convert.ToInt32(h / 2 - k1 * obj.y));

                vector Norm = obj.Normalize();
                double L = Norm.dot(lgt);
                int index = Convert.ToInt32(L * lgt_strength / obj.z * 2);
                if (_z > zBuffer[x1, y1])
                {
                    zBuffer[x1, y1] = _z;
                    output[x1, y1] = grad[Nums<int>.crop(7, 0, index)];
                }
            }
        }
    }


    public override void Render(double k)
    {
        //fill(Math.PI / 3);
        fill(k);
        
    }
}