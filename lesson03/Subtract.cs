Random random = new();

int a = random.Next(1, 10);
int b = random.Next(1, 10);

if (a < b)
{
    (a, b) = (b, a);
}

//Console.WriteLine($"{a} - {b} = {a - b}");
Console.WriteLine($"What is {a} - {b}?");
int input = int.Parse(Console.ReadLine() ?? "0");
int answer = a - b;

if (input == answer)
{
    Console.WriteLine($"Correct");
}
else
{
    Console.WriteLine($"Incorrect. {answer} is the correct answer");

}
