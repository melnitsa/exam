
double depositWithInterest = 1000;
int deposit = 1000;
bool exit = false;

for (int i = 0; i <= 10; i++)
{
    depositWithInterest = depositWithInterest * 0.02 + depositWithInterest;

    if(depositWithInterest - deposit >= 30 && exit != true)
    {
        Console.WriteLine("Величина ежемиесячного увеличения вклада привысила 30 рублей через " + i + " месяцев");
        exit = true;
    }
    if(depositWithInterest > 1200)
    {
        Console.WriteLine("Размер вклада привысил 1200р через " + i + " месяцев");
        break;
    }
}
Console.ReadKey();