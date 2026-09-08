namespace HelloWorldConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello, Visual Studio World!");
            Console.Write(" This writes on the same line, without adding newline");
            Console.WriteLine("Write text and create newline");
            Console.WriteLine("Line1\nLine1\nLine3\n"); // escape characters/sequence
            Console.WriteLine("""
                Line 1
                line 2
                Line 3
                """); // raw string literal

            string mystring = "something 123";
            int myint = 4;
            Console.WriteLine(mystring + myint);
            char a = 'A';
            char b = 'B';
            char c = 'C';
            Console.WriteLine(a + b + c);



        }
    }
}
