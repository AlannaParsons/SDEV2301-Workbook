int teamSize;
do
{
    Console.WriteLine("Enter a valid team size: ");
    teamSize = int.Parse(Console.ReadLine() ?? "");
} while (teamSize < 9 || teamSize > 15);
Console.WriteLine($"Team size: {teamSize}");