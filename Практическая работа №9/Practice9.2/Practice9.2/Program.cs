namespace Practice9._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первою строку: ");
            string str = Console.ReadLine();

            Console.WriteLine("Введите вторую строку: ");
            string str1 = Console.ReadLine();

            Console.WriteLine("Введите символ: ");
            char ch = Convert.ToChar(Console.ReadLine());

            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch)
                {
                    str = str.Insert(i, str1);
                    i += str1.Length;
                }
            }
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}