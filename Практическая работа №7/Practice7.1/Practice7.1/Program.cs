namespace Practice7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину стороны матрицы: ");
            int N = int.Parse(Console.ReadLine());

            int[,] array = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i == j)
                    {
                        array[i, j] = N - i;

                    }

                    Console.Write(array[i, j] + " ");
                }

                Console.WriteLine();
            }
            Console.ReadKey();
        }


        //Каждый элемент двумерного массива имеет два индекса, первый определяет номер строки,
        //второй - номер столбца, на пересечении которых находится элемент.Нумерация строк и столбцов начинается с нуляПри обращении к свойству Length для двумерного массива получаем общее 
        //количество элементов в массиве.Чтобы получить количество строк нужно
        //обратиться к методу GetLength с параметром 0. Чтобы получить количество
        //столбцов - к методу GetLength с параметром 1.
    }
}