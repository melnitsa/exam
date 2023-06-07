namespace Practice7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину стороны матрицы: ");
            int N = int.Parse(Console.ReadLine());
            int index = 0;
            int temp;

            int[,] array = new int[N, N];

            Console.WriteLine("Заполните матрицу");
            for (int i = 0; 1 < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());

                }
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {

                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            int max = array[0, 0];

            for (int i = 1; i < N; i++)
            {
                for (int j = 0; j < N; j++)

                    if (i == j)
                    {
                        if (array[i, i] > max)
                        {
                            max = array[i, i];
                            index = i;
                        }
                    }
            }

            Console.WriteLine("Введите номер строки: ");
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                temp = array[T, i];
                array[T, i] = array[index, i];
                array[index, i] = temp;
            }

            Console.WriteLine("\nПреобразованная матрица: ");

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(array[i, j] + " ");

                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}