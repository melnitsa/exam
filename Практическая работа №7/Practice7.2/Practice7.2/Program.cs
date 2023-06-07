namespace Practice7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину стороны матрицы: ");
            int N = int.Parse(Console.ReadLine());
            int A = 0;
            int columnCount = 0;
            int[,] array = new int[N,
            N];
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

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (array[j, i] != 0)
                    {
                        A++;
                    }
                    if (A == N)
                    {
                        columnCount++;
                    }
                }
                A = 0;
            }
            Console.WriteLine(columnCount);
            Console.ReadKey();
        }
    }
}