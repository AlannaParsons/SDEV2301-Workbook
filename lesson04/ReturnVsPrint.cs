
class Program
{
    static void Main()
    {
        PrintSum(4, 5);
        Console.WriteLine(Add(4, 5));
    }

    static void PrintSum(int a, int b)
    {
        Console.WriteLine(a + b);
    }

    static int Add(int a, int b)
    {
        return a + b;
    }
}