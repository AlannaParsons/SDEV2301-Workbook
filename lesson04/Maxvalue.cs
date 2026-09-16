
class Program
{
    static void Main()
    {
        Console.WriteLine(MaxValue(4, 9));
        Console.WriteLine(MaxValue(1.4, 1.9));
    }

    static int MaxValue(int a, int b)
        => a > b ? a : b;

    static double MaxValue(double a, double b)
        => a > b ? a : b;
}