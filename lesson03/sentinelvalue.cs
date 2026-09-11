Console.WriteLine("Enter values to start suming: ");
int value = int.Parse(Console.ReadLine() ?? "");
int sum = 0;
while (value != 0)
{
    sum += value;
    Console.WriteLine("Enter value (0 to quit): ");
    value = int.Parse(Console.ReadLine() ?? "");
}
Console.WriteLine($"Total value: {sum}");