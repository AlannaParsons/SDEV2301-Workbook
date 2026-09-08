Console.Write($"Hourly rate: ");
string inputRate = Console.ReadLine() ?? "no input";
decimal rate = decimal.Parse(inputRate);

Console.Write($"Hours worked: ");
string inputHours = Console.ReadLine() ?? "no input";
decimal hours = decimal.Parse(inputHours);

Console.Write($"You have worked {hours} at {rate} for total pay of ${hours * rate}");
