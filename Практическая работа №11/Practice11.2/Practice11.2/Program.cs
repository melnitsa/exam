namespace Practice11._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath2 = @"C:\Практики\Практическая работа №11\Practice11.2\11.22.txt";

            string[] array = System.IO.File.ReadAllLines(@"C:\Практики\Практическая работа №11\Practice11.2\11.2.txt");

            Console.WriteLine("Исходная матрица: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + " ");
            }

            string[] arrayLine = array[0].Split();
            string[] arrauColumn = array[1].Split();

            int[] mas = new int[arrayLine.Length];
            int sum = 0;
            double midl = 0;

            for (int i = 0; i < arrayLine.Length; i++)
            {
                mas[i] = int.Parse(arrayLine[i]) + int.Parse(arrauColumn[i]);
                sum += mas[i];
            }
            midl = sum / arrayLine.Length;

            int lowerValue = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] < midl)
                {
                    lowerValue++;
                }
            }

            Console.WriteLine("Новый массив: ");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");
            }

            Console.WriteLine("\nСреднее арифметическое: " + midl);

            Console.WriteLine("Количество элементов массива, меньших среднего арифметического: " + lowerValue);

            FileStream fileStram = null;

            using (fileStram = File.Open(filePath2, FileMode.Append))
            {
                using (StreamWriter output = new StreamWriter(fileStram))
                {
                    output.Write("Количество элементов массива, меньших среднего арифметического: ");
                    output.Write(lowerValue.ToString());
                }
            }
            Console.ReadKey();
        }
    }
}