Console.Write($"Enter a number: ");
string inputNumber = Console.ReadLine() ?? "no input";
int num = int.Parse(inputNumber);
Console.WriteLine($"Here is what you entered: {num}");