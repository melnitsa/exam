namespace Practice14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool menu = false;
            SingleLinkedList list = new SingleLinkedList();
            int count;
            string filePath = File.ReadAllText(@"C:\Практики\Практическая работа №14\Аптека.txt");
            string[] records = filePath.Split(';');
            count = records.Length;
            for (int i = 0; i != count / 5; i++)
            {
                int n = i * 5;
                List newnode = new List(records[n++], records[n++], records[n++], records[n++], records[n++]);
                list.Add(newnode);
            }

            while (menu != true)
            {
                Console.WriteLine("Выбор опции: ");
                Console.WriteLine("1 - Показать список");
                Console.WriteLine("2 - Поиск");
                Console.WriteLine("3 - Удалить");
                Console.WriteLine("4 - Вставить");
                Console.WriteLine("5 - Выход");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            list.Print();
                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Введите данные для поиска: "); string search = Console.ReadLine();
                            list.Find(search);
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Введите позицию которую вы хотите удалить: "); int pos = Convert.ToInt32(Console.ReadLine());
                            list.Remove(pos);
                            Console.ReadKey();
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Введите позицую: "); int pos = Convert.ToInt32(Console.ReadLine()); Console.WriteLine("Введите что вы хотите вставить"); string searchString = Console.ReadLine();
                            list.Insert(pos, new List(searchString));
                            Console.ReadKey();
                            break;
                        }
                    case 5:
                        {
                            Environment.Exit(0);
                            Console.ReadKey();
                            break;
                        }
                }
                Console.Clear();
                Console.ReadKey();
            }
        }
    }

    public class List
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string DateOfManufacture { get; set; }
        public string ExpirationDate { get; set; }
        public string CashinerName { get; set; }

        public List Link { get; set; }
        public List(string name, string type, string dateOfManufacture, string expirationDate, string cashinerName)
        {
            Name = name;
            Type = type;
            DateOfManufacture = dateOfManufacture;
            ExpirationDate = expirationDate;
            CashinerName = cashinerName;
        }
        public List(string Name)
        {
            this.Name = Name;
        }
    }

    public class SingleLinkedList
    {
        public List First { get; private set; }
        public List Last { get; private set; }
        public void Print()
        {
            List list = First;
            while (list != null)
            {
                Console.WriteLine($"{list.Name}\n{list.Type}\n{list.DateOfManufacture}\n{list.ExpirationDate}\n{list.CashinerName}\n");
                if (list == list.Link)
                    return;
                list = list.Link;
            }
        }
        public void Find(string search)
        {
            List list = First;
            int count = 0;
            int k = 0;
            while (list != null)
            {
                if (list.Name == search)
                {
                    count++;
                }
                k++;
                list = list.Link;
            }
            Console.WriteLine($"Найдено {count} записей соответствующих критерию поиска");
            Console.WriteLine("Находится на позиции {0}", k);
        }
        public void Insert(int pos, List list)
        {
            if (pos < 1) return;
            List current = First;
            List previuos = null;
            int n = 0;
            while (++n != pos)
            {
                previuos = current;
                if (current.Link == null)
                {
                    current.Link = list;
                    Last = list;
                    return;
                }
                current = current.Link;
            }
            list.Link = current;
            if (previuos == null)
                First = list;
            else
                previuos.Link = list;
        }
        public void Remove(int pos)
        {
            if (pos < 1) return;
            List current = First;
            List previous = null;
            int n = 0;
            while (current != null)
            {
                if (++n == pos)
                {
                    if (previous == null)
                        First = current.Link;
                    else
                        previous.Link = current.Link;
                    if (current.Link == null)
                        Last = current;
                    break;
                }
                previous = current;
                current = current.Link;
            }
            Console.WriteLine("Успешно!");
        }
        public void Add(List list)
        {
            if (First == null) First = list;
            if (Last == null) Last = list;
            Last.Link = list;
            Last = list;
        }
    }
}




//Динамической структурой называется множество объектов, состав и 
//взаимное расположение которых в процессе выполнения программы может 
//динамически изменяться. 
//Операции по модификации динамических структур: 
// создание / разрушение структуры,
// включение объектов в структуру / исключение объектов из структуры,
// выделение подмножества объектов структуры по определенным 
//признакам,
// объединение нескольких подмножеств объектов в определенном порядке 
//в единую структуру. 
//Если на множестве объектов определено отношение порядка, различают 
//линейные и нелинейные структуры данных. 
//Линейной динамической структурой (связанным списком) называется
//множество объектов (элементов, узлов) S ={ si}, i = 1,...,n, на котором определены 
//отношения предшествования / следования, причем для любого объекта si, i = 2,..., n-1
//существует единственный “предшественник” si-1 и единственный “последователь” 
//si+1. Объект s1 имеет последователя, но не имеет предшественника и является 
//первым элементом списка, объект sn имеет предшественника, но не имеет 
//последователя и является “хвостом” списка. Ситуация n=0 определяет особое 
//состояние: “список пуст”. 
//Реализация динамической структуры линейного списка на связанной памяти 
//требует включения в структуру каждого его элемента полей для связи с соседними 
//элементами. В зависимости от того, с каким количеством соседних объектов связан 
//каждый объект в списке, различаются односвязные, двусвязные и многосвязные 
//списки.
