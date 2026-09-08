int number = 89;
string random = "something";
bool T = (3 > 2);
Console.WriteLine($"{random} : {number}");
Console.WriteLine($"Is 3 greater than 2 : {T}");

Console.Write($"Enter something: ");
// will return after enter key is pressed. always returns a string
string input = Console.ReadLine() ?? "no input";
Console.WriteLine($"Here is what you entered: {input}");
