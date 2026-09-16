class Program
{
    static void Main()
    {
        double cups = GetCups();
        double ounces = CupsToOunces(cups);
        DisplayResults(cups, ounces);
    }
    static double GetCups()
    {
        double cups = 0;
        Console.WriteLine($"Enter the number of cups: ");
        while (!double.TryParse(Console.ReadLine(), out cups))
        {
            Console.WriteLine("Invalid input, try again");
            Console.WriteLine($"Enter the number of cups: ");
        }
        return cups;
    }

    static double CupsToOunces(double cups) => cups * 8.0;

    static void DisplayResults(double cups, double ounces)
    {
        Console.WriteLine($"Cups {cups} = {ounces} fluid ounces");
    }

}
