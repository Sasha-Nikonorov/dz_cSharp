Console.WriteLine("Пожалуйста, введите целое число");
string? numberAString = Console.ReadLine();
int numberA = int.Parse(numberAString!);

Console.WriteLine("Пожалуйста, введите целое число");
string? numberBString = Console.ReadLine();
int numberB = int.Parse(numberBString!);

if(numberA > numberB)
{
    Console.WriteLine(numberA);
}
else
{
    Console.WriteLine(numberB);
}
if(numberA == numberB)
{
    Console.WriteLine("Веденные числа не отличаются");
}

