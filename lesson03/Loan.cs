int salary = 29000;
int years = 3;

bool salaryOk = salary >= 30000;
bool expereienceOk = years >= 2;
if (!salaryOk)
{
    Console.WriteLine("not enough money");
}
if (!expereienceOk)
{
    Console.WriteLine("not enough experience");
}
if (salaryOk && expereienceOk)
{
    Console.WriteLine("Qualifies");
}
