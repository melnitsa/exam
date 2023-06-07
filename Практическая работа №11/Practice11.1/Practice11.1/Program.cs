
using System.IO;


namespace Practice11._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите подстроку из 3 символов: ");
            string subString = Console.ReadLine();
            int count = 0;
            string newStr;

            string[] array = System.IO.File.ReadAllLines(@"C:\Практики\Практическая работа №11\Practice11.1\11.1.txt");

            for (int i = 0; i < array.Length; i++)
            {
                newStr = new string(array[i]);
                string[] mass = newStr.Split();

                for (int l = 0; l < mass.Length; l++)
                {
                    if (mass[l].IndexOf(subString) != -1)
                    {
                        Console.WriteLine(mass[l] + " ");
                        count++;
                    }
                }

            }
            Console.WriteLine("Подстрока встречается " + count + " раз");
            Console.ReadKey();
        }
    }
}



//Теоретическая часть.
//В С# есть пространство имен System.IO, в котором реализованы все необходимые классы 
//для работы с файлами.
//Для создания пустого файла, в классе File есть метод Create(). Он принимает один аргумент 
//– путь. Ниже приведен пример создания пустого текстового файла new_file.txt на диске D:

//static void Main(string[] args)
//{
//    File.Create("D:\\new_file.txt");
//}

//Если файл с таким именем уже существует, он будет переписан на новый пустой файл.
//Метод WriteAllText() создает новый файл (если такого нет), либо открывает существующий 
//и записывает текст, заменяя всё, что было в файле:

//static void Main(string[] args)
//{
//    File.WriteAllText("D:\\new_file.txt", "текст");
//}

//Метод AppendAllText() работает, как и метод WriteAllText() за исключением того, что 
//новый текст дописывается в конец файла, а не переписывает всё что было в файле:

//static void Main(string[] args)
//{
//    File.AppendAllText("D:\\new_file.txt", "текст метода AppendAllText ()");
//    //допишет текст в конец файла
//}

//Метод Delete() удаляет файл по указанyому пути:
//static void Main(string[] args)
//{
//    File.Delete("d:\\test.txt"); //удаление файла
//}

//Сохранение массива строк в файле:
//static void Main(string[] args)
//{
//    File.WriteAllLines("test1.txt", new[] { "Hello", "world" })
//}

//Чтение данных из файла:
//static void Main(string[] args)
//{
//    string text = File.ReadAllText("text.txt");
//}

//Чтение массива строк из файла:
//static void Main(string[] args)
//{
//    string[] lines = File.ReadAllLines("text1.txt");
//}

//Пример.
//Записать текст в конец файла (если файл не существует, создать файл).
//using System;
//// подключаем библиотеку для работы с файлами
//using System.IO;
//namespace ConsoleApplication1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // имя файла
//            string filePath = @"D:\1.txt";
//            // текст запишем в файл
//            string text = "Hello!";
//            FileStream fileStream = null;
//            // проверяем существует ли файл 
//            if (!File.Exists(filePath))
//                fileStream = File.Create(filePath); // создаем файл
//            else
//                fileStream = File.Open(filePath, FileMode.Append); // открываем 
//            файл и в конец будут добавлены данные
//             // получаем поток
//             StreamWriter output = new StreamWriter(fileStream);
//            // записываем текст в поток
//            output.Write(text);
//            // закрываем поток
//            output.Close();
//        }
//    }
//}
