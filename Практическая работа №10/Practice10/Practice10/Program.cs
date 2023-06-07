namespace Practice10
{
    static class name
    {
        public static string text;
        public static string word;
        static void Main(string[] args)
        {

            bool exit = false;

            while (exit != true)
            {

                Console.WriteLine("Выберите пункт меню:\n1 - Ввод данных\n2 - Просмотр данных\n3 - Обработка\n4 - Выход");
                string menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        first();
                        break;
                    case "2":
                        second();
                        break;
                    case "3":
                        third();
                        break;
                    case "4":
                        exit = true;
                        break;

                }
                Console.Clear();

            }
            static void first()
            {
                Console.Write("Введите текст: ");
                text = Console.ReadLine();
                Console.Write("Введите слово: ");
                word = Console.ReadLine();
                Console.ReadKey();
            }
            static void second()
            {
                Console.Write("Введите текст: ");
                text = Console.ReadLine();
                Console.Write("Введите слово: ");
                word = Console.ReadLine();
                Console.ReadKey();
            }
            static void third()
            {
                if (word.Length > 4)
                {
                    Console.WriteLine("В слове более 4 символов.");

                }
                for (int i = 0, j = 0; i < word.Length; i++, j = 0)
                {
                    while (true)
                    {
                        if (word[i] == text[j])
                        {
                            break;
                        }
                        if (j == text.Length - 1)
                        {
                            Console.WriteLine("В данном тексте нет всех букв слова.");
                        }
                        j++;
                    }
                }
                Console.WriteLine("В данном тексте есть все буквы слова.");
                Console.ReadKey();
            }
        }
    }
}


//Методы содержат собой набор операторов, которые выполняют определенные действия. 
//Общее определение методов выглядит следующим образом:

//[модификаторы] тип_возвращаемого_значения название_метода([параметры])
//{
//    // тело метода
//}

//Модификаторы и параметры необязательны.

//По умолчанию консольная программа на языке C# должна содержать как минимум один 
//метод - метод Main, который является точкой входа в приложение:
//static void Main(string[] args)
//{

//}
//Ключевое слово static является модификатором.Далее идет тип возвращаемого значения. В
//данном случае ключевое слово void указывает на то, что метод ничего не возвращает.Далее
//идет название метода - Main и в скобках параметры - string[] args. И в фигурные скобки
//заключено тело метода - все действия, которые он выполняет.В данном случае метод Main
//пуст, он не содержит никаких операторов и по сути ничего не выполняет.
//Определим еще пару методов:
//using System;
//namespace HelloApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//        }
//        static void SayHello()
//        {
//            Console.WriteLine("Hello");
//        }
//        static void SayGoodbye()
//        {
//            Console.WriteLine("GoodBye");
//        }
//    }
//}
//Оба метода определены в рамках класса Program, они имеют модификатор static, а в 
//качестве возвращаемого типа для них определен тип void. То есть данные методы ничего 
//не возвращают, просто производят некоторые действия. И также оба метода не имеют 
//никаких параметров, поэтому после названия метода указаны пустые скобки.
//Чтобы использовать методы SayHello и SayGoodbye в программе, необходимо вызвать их в 
//методе Main. Для вызова метода указывается его имя, после которого в скобках идут 
//значения для его параметров (если метод принимает параметры):
//название_метода(значения_для_параметров_метода);
//…
// static void Main(string[] args)
//{
//    SayHello();
//    SayGoodbye();
//    Console.ReadKey();
//}
//…
//Метод может возвращать значение, какой-либо результат. Если метод имеет любой другой 
//тип, отличный от void, то такой метод обязан вернуть значение этого типа. Для этого 
//применяется оператор return, после которого идет возвращаемое значение:
//return возвращаемое значение;
//Например:
//static string GetHello()
//{
//    return "Hello";
//}
//После оператора return также можно указывать сложные выражения, которые возвращают 
//определенный результат.
//static int GetSum()
//{
//    int x = 2;
//    int y = 3;
//    return x + y;
//}
//Оператор return не только возвращает значение, но и производит выход из метода.