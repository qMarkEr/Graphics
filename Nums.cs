namespace GEngine;

static class Nums<T> where T : IComparable{

    public static T min(T val1, T val2) 
    {
        return val1.CompareTo(val2) >= 0 ? val2 : val1;
    }
    public static T max(T val1, T val2) 
    {
        return val1.CompareTo(val2) >= 0 ? val1 : val2;
    }
        
    public static T crop(T mx, T mn, T val)
    {
        return max(min(val, mx), mn);
    }
}