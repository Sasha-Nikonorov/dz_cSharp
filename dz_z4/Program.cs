Console.WriteLine("Пожалуйста, введите целое число");
string? numberAString = Console.ReadLine();
int numberA = int.Parse(numberAString!);

Console.WriteLine("Пожалуйста, введите целое число");
string? numberBString = Console.ReadLine();
int numberB = int.Parse(numberBString!);

Console.WriteLine("Пожалуйста, введите целое число");
string? numberCString = Console.ReadLine();
int numberC = int.Parse(numberCString!);

int max = numberA;

if (numberA > max ) max = numberA;
if (numberB > max ) max = numberB;
if (numberC > max ) max = numberC;

Console.Write("max = ");
Console.WriteLine(max);