

struct Record
{
   public string name;
   public string type;
   public string dateOfManufacture;
   public string expirationDate;
   public string cashierName;
}

// Класс для работы с базой данных
class Database
{
    private Record[] records;

    public Database(int size)
    {
        records = new Record[size];
    }

    // Метод для заполнения базы данных из текстового файла
    public void ReadDataFromFile(string filePath)
    {
        string[] lines = File.ReadAllLines(filePath);
        for (int i = 0; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(';');
            records[i].name = data[0]; 
            records[i].type = data[1];
            records[i].dateOfManufacture = data[2];
            records[i].expirationDate = data[3];
            records[i].cashierName = data[4];
        }
    }

    // Метод для вывода всех записей в базе данных
    public void Print()
    {
        Console.WriteLine("Список всех записей в базе данных:");
        for (int i = 0; i < records.Length; i++)
        {
            Console.WriteLine("{0} - Название лекарства: {1}, Внутреннее/наружное: {2}, Дата изготовления: {3},Cрок годности {4},ФИО кассира {5} ", i + 1, records[i].name, records[i].type, records[i].dateOfManufacture, records[i].expirationDate, records[i].cashierName);
        }
    }

    // Метод для поиска записей по заданному критерию
    public void Search(string searchString)
    {
        Console.WriteLine("Список всех записей, содержащих \"{0}\" в имени или адресе:", searchString);

        for (int i = 0; i < records.Length; i++)
        {
            if (records[i].name.Contains(searchString) || records[i].type.Contains(searchString) || records[i].dateOfManufacture.Contains(searchString) || records[i].expirationDate.Contains(searchString) || records[i].cashierName.Contains(searchString))
            {
                Console.WriteLine("{0} - Название лекарства: {1}, Внутреннее/наружное: {2}, Дата изготовления: {3},Cрок годности {4},ФИО кассира {5} ", i + 1, records[i].name, records[i].type, records[i].dateOfManufacture, records[i].expirationDate, records[i].cashierName);
                break;
            }
            else
            {
                Console.WriteLine("Такой записи не существует");
                break;
            }
        }
    }
}

// Основной класс программы
class Program
{
    static void Main()
    {
        Console.Write("Введите размер базы данных: ");
        int size = int.Parse(Console.ReadLine());

        Database db = new Database(size);

        
        string filePath = "C:\\Users\\nikrm\\OneDrive\\Рабочий стол\\Аптека.txt";
        db.ReadDataFromFile(filePath);
        Console.Clear();
        int choice = 0;
        while (choice != 3)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1 - Просмотреть все записи базы данных");
            Console.WriteLine("2 - Найти записи по заданному критерию");
            Console.WriteLine("3 - Выход");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    db.Print();
                    Console.ReadKey();
                    break;
                
                case 2:
                    Console.Write("Введите критерий поиска: ");
                    string searchString = Console.ReadLine();
                    db.Search(searchString);
                    Console.ReadKey();
                    break;
            }
            Console.Clear();
        }
    }
}
//Структуры - это составные типы данных, содержащие свойства, методы и другие элементы,
//которые могут быть созданы как переменные. 
//Все структуры наследуются от базового класса System.ValueType и являются типами 
//значений, тогда как классы - ссылочные типы.
//У каждой структуры имеются свои члены: методы, поля, индексаторы, свойства,
//операторные методы и события. В структурах допускается также определять конструкторы,
//но не деструкторы. В то же время для структуры нельзя определить конструктор,
//используемый по умолчанию (т.е. конструктор без параметров).
//Структуры объявляются при помощи ключевого слова struct:
//public struct Book
//{
//    public string Name;
//    public string Year;
//    public string Author;
//}
//Экземпляр структуры может быть создан с помощью оператора new таким же образом, как 
//и объект класса, но в этом нет особой необходимости. Когда используется оператор new, то
//вызывается конструктор, используемый по умолчанию. А когда этот оператор не 
//используется, объект по-прежнему создается, хотя и не инициализируется. В этом случае 
//инициализацию любых членов структуры придется выполнить вручную.
//Создание экземпляра структуры:
//1.без ключевого слова new(если все поля структуры доступны - имеют
//модификатор public):
//static void Main(string[] args)
//{
//    Book b;
//    b.Name = "BookName";
//}
//2.с оператором new: 
//static void Main(string[] args)
//{
//    Book b = new Book(“BookName”);
//}
//В качестве полей структуры могут выступать любые встроенные типы данных и даже 
//другие структуры. На имена полей накладываются те же ограничения, что и на обычные 
//переменные. Внутри одной структуры не должно быть полей с одинаковыми именами. Имя 
//поля не должно начинаться с цифры. Регистр учитывается.
//Можно создать массив структур - массив, хранящий элементы типа структуры. Делается 
//это аналогично, как при создании массива переменных любого стандартного типа.
//Чтобы объявить массив структур, вначале необходимо определить структуру, а затем 
//объявить переменную массива этого же типа.
