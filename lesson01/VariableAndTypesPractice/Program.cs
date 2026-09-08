using System.Xml.Linq;

namespace Lesson2Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare an integer variable called age and assign it the value 21
            int age = 34;

            // TODO: Declare a string variable called name and assign it your name
            string name = "Alanna";

            // TODO: Declare a double variable called gpa and assign it the value 3.5
            double gpa = 3.4;

            // TODO: Declare a boolean variable called isFullTime and assign it true
            bool isFullTime = true;

            decimal money = 100.01m;

            // Output the variables
            Console.WriteLine("Student Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("GPA: " + gpa);
            Console.WriteLine("Full-Time: " + isFullTime);
            Console.WriteLine("Money has to use m: " + money);

            // TODO: Predict the output before running
            // Student Name: Alanna
            // Age: 34
            // GPA: 3.4
            // Full-Time: true (WRONG.correction: True)
        }
    }
}