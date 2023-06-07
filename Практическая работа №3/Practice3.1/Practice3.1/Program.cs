Console.WriteLine("Введите a: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите b: ");
int b = int.Parse(Console.ReadLine());

int x = 0;

if (a > b)
{
    x = 5 * a + b;
}
else if (a == b)
{
    x = -125;
}
else
{
    x = (a - 5) / b;
}
Console.WriteLine("X = " + x);


Console.ReadKey();
