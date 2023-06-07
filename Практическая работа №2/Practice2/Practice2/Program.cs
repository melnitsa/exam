Console.WriteLine("Введите первое число: ");
double a = double.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
double b = double.Parse(Console.ReadLine());

double middlecube = ((a + b) / 2);
double geometricMean = (Math.Sqrt(a * b));

Console.WriteLine("Среднее арифметическое равно " + middlecube);
Console.WriteLine("Среднее геометрическое равно " + geometricMean);

Console.ReadKey();
