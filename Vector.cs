namespace GEngine;

public struct Point
{
    public double x, y, z;

    public Point(double x1, double y1, double z1)
    {
        x = x1;
        y = y1;
        z = z1;
    }
}
    
public class vector 
{
    public double x, y, z;
    public vector() {}
    public vector(double x1, double y1, double z1)
    {
        x = x1;
        y = y1;
        z = z1;
    }
    public vector(vector a)
    {
        this.x = a.x;
        this.y = a.y;
        this.z = a.z;
    }
    public vector(Point a, Point b)
    {
        this.x = b.x - a.x;
        this.y = b.y - a.y;
        this.z = b.z - a.z;
    }
    public vector(Point a)
    {
        this.x = a.x;
        this.y = a.y;
        this.z = a.z;
    }

    public double len
    {
        get => Math.Sqrt((double)x * x + y * y + z * z);
    }

    public vector Normalize()
    {
        return new vector(x / len, y / len, z / len);
    }

    public vector Cross(vector a)
    {
        return new vector(this.y * a.z - this.z * a.y, this.z * a.x - this.x * a.z, this.x * a.y - this.y * a.x);
    }

    public double dot(vector a)
    {
        return a.x * this.x + a.y * this.y + a.z * this.z;
    }
        
}