

Console.WriteLine("Введите x: ");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Введите y: ");
int y = int.Parse(Console.ReadLine());

if((x >= 0) && (x * x + y * y <= 4 * 4) && (y >= 0))
{
    Console.WriteLine("Да,принадлежит");
}
else if((x >= 0) && (x * x + y * y <= 5 * 5) && (y <= 0))
{
    Console.WriteLine("Да,принадлежит");
}
else
{
    Console.WriteLine("Нет, не принадлежит");
}

Console.ReadKey();