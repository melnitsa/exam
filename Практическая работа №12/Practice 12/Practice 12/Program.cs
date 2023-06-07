using System;

namespace ArrayIntTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayInt2 type = new ArrayInt2(4, 5);
            type.arrayIntOut("Исходный массив:");

            int min = type.minArray(out int minIndex1, out int minIndex2);
            int max = type.maxArray(out int maxIndex1, out int maxIndex2);

            Console.WriteLine("Минимум = " + min);
            Console.WriteLine("Максимум = " + max);

            type.changeElements();
            type.arrayIntOut("Массив после приобразования: ");
            
            Console.ReadKey();
        }
    }

    public class ArrayInt2
    {
        public int row { get; private set; }
        //public int Row
        //{
        //    get
        //    {
        //        return row;
        //    }
        //    set
        //    {
        //        row = value;
        //    }
        //}
        public int column { get; private set; }
        //public int Column
        //{
        //    get
        //    {
        //        return column;
        //    }
        //    set
        //    {
        //        column = value;
        //    }
        //}
        public int[,] array { get; private set; }
        //public int[,] Array
        //{
        //    get
        //    {
        //        return array;
        //    }
        //}
        public ArrayInt2(int rows, int columns)
        {
            row = rows;
            column = columns;
            array = new int[row, column];
            Console.WriteLine($"Введите по строкам {row} x {column} элементов целочисленного двухмерного массива");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write("Введите число: ");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public int minArray(out int minIndex1, out int minIndex2)
        {
            int min = array[0, 0];
            minIndex1 = 0;
            minIndex2 = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                        minIndex1 = i;
                        minIndex2 = j;
                    }
                }
            }
            return min;
        }
        public int maxArray(out int maxIndex1, out int maxIndex2)
        {
            int max = array[0, 0];
            maxIndex1 = 0;
            maxIndex2 = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        maxIndex1 = i;
                        maxIndex2 = j;
                    }
                }
            }
            return max;
        }
        public void changeElements()
        {
            int min = array[0, 0], max = array[0, 0];
            int minIndex1 = 0, minIndex2 = 0;
            int maxIndex1 = 0, maxIndex2 = 0;

            for (int i = 0; i < row; i++)
            {
                for(int j = 0; j < column; j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                        minIndex1 = i;
                        minIndex2 = j;
                    }
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        maxIndex1 = i;
                        maxIndex2 = j;
                    }
                }
            }
            int temp = array[minIndex1, minIndex2];
            array[minIndex1, minIndex2] = array[maxIndex1, maxIndex2];
            array[maxIndex1, maxIndex2] = temp;
        }
        public void arrayIntOut(string info)
        {
            Console.WriteLine(info);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}


//С# является полноценным объектно-ориентированным языком, следовательно, программу 
//на C# можно представить в виде взаимосвязанных взаимодействующих между собой 
//объектов. 
//Описанием объекта является класс, а объект представляет экземпляр этого класса. 
//Класс определяется с помощью ключевого слова сlass: 
//class Book
//{
//}
//Вся функциональность класса представлена его членами - полями (полями называются 
//переменные класса), свойствами, методами, событиями. 
//class Book
//{
//    public string name;
//    public string author;
//    public int year;
//    public void Info()
//    {
//        Console.WriteLine("Книга '{0}' (автор {1}) была издана в {2} году", name,
//       author, year);
//    }
//}
//Кроме обычных методов в классах используются также и специальные методы, которые 
//называются конструкторами. Конструкторы вызываются при создании нового объекта 
//данного класса. Отличительной чертой конструктора является то, что его название должно 
//совпадать с названием класса: 
//class Book
//{
//    public string name;
//    public string author;
//    public int year;
//    public Book()
//    { }
//    public Book(string name, string author, int year)
//    {
//        this.name = name;
//        this.author = author;
//        this.year = year;
//    }
//    public void Info()
//    {
//        Console.WriteLine("Книга '{0}' (автор {1}) была издана в {2} году", name,
//       author, year);
//    }
//}
//Одно из назначений конструктора - начальная инициализация членов класса. В данном 
//случае мы использовали два конструктора. Один пустой. Второй конструктор наполняет 
//поля класса начальными значениями, которые передаются через его параметры. 
//Поскольку имена параметров и имена полей (name, author, year) в данном случае совпадают,
//то мы используем ключевое слово this. Это ключевое слово представляет ссылку на 
//текущий экземпляр класса. Поэтому в выражении this.name = name; первая часть this.name 
//означает, что name - это поле текущего класса, а не название параметра name. Если бы у нас 
//параметры и поля назывались по-разному, то использовать слово this было бы 
//необязательно. 