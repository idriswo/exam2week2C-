

class MyMath
{
    public double PI = 3.14;
    public double E = 2.71;

    public int Abs(int n)
    {
        return Math.Abs(n);
    }


    public double AbsDouble(double n)
    {
        return Math.Abs(n);
    }


    public double Pow(double x, double y)
    {
        double sum = Math.Pow(x, y);
        return sum;
    }

    public double Sqrt(int d)
    {
        return Math.Sqrt(d);
    }

    public int Max(int val1, int val2)
    {
        return Math.Max(val1, val2);
    }

    public int Min(int val1, int val2)
    {
        return Math.Min(val1, val2);
    }


}