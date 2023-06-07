namespace Practice5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double distance = 10;
            int days = 0;

            do
            {
                distance = distance * 0.1 + distance;
                days++;

            }
            while (distance <= 20);

            Console.WriteLine("На " + days + " день он пробежит больше 20 км.");

            Console.ReadKey();
        }
    }
}