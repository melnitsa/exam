namespace Practice8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер матрицы: ");
            int length = int.Parse(Console.ReadLine());

            int[,] array = new int[length, length];

            Console.WriteLine("Заполните массив: ");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine("Введите число: ");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Массив до сортировки: ");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            int lengthOfArrayForSort = 0;

            for (int i = 0; i < length - 1; i++)
            {
                lengthOfArrayForSort += length - (length - (i + 1));
            }

            int[] arrayForSort = new int[lengthOfArrayForSort];

            lengthOfArrayForSort = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == j)

                        break;
                    array[i, j] = arrayForSort[lengthOfArrayForSort];
                    lengthOfArrayForSort++;

                }
            }

            Console.WriteLine("Массив после сортировки: ");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}