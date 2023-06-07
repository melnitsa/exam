Console.WriteLine("Введите массу m - ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите высоту h - ");
int h = int.Parse(Console.ReadLine());
Console.WriteLine("Введите скорость v - ");
int v = int.Parse(Console.ReadLine());


double e = (m * Math.Pow(v, 2) / 2);
double p = (m * 9.8 * h);

Console.WriteLine($"Кинетическая энергия тела равна {e}, Потенциальная энергия тела равна {p}");

Console.ReadKey();