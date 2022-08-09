Console.WriteLine("Пожалуйста, введите целое число");
string? numberAString = Console.ReadLine();
int numberA = int.Parse(numberAString!);

int numberB = numberA / 2;

int numberC = numberB * 2;

if(numberA == numberC)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
