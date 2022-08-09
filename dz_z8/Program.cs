Console.WriteLine("Пожалуйста, введите целое число");
string? numberAString = Console.ReadLine();
int numberA = int.Parse(numberAString!);

int count = 1;

while(count <= numberA)
{
    if (count%2==0)
    {
    Console.WriteLine(count);
    }
    count = count + 1;
}