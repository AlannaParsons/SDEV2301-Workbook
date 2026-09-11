using static System.Console; // Enables direct access to all static methods in console class 
// Read an initial data
Write("Enter an integer (the input ends if it is 0): ");
int data = int.Parse(ReadLine() ?? "0");
// Keep reading until the input is 0
int sum = 0;
while (data != 0)
{
    sum += data;
    // Read the next data
    Write("Enter an integer (the input ends if it is 0): ");
    data = int.Parse(ReadLine() ?? "0");
}
WriteLine("The sum is " + sum);

