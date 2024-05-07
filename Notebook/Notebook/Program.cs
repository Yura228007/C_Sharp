using System;
using System.Collections;
using System.Collections.Specialized;

class Program
{
    static SortedList records = new SortedList();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Добавить запись");
            Console.WriteLine("2. Удалить запись");
            Console.WriteLine("3. Поиск по ключу");
            Console.WriteLine("4. Выйти");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddRecord();
                    break;
                case 2:
                    RemoveRecord();
                    break;
                case 3:
                    SearchByKey();
                    break;
                case 4:
                    return;
            }
        }
        
    }

    static void AddRecord()
    {
        Console.WriteLine("Введите ключ записи:");
        string key = Console.ReadLine();

        ListDictionary record = new ListDictionary();

        Console.WriteLine("Введите название записи:");
        record.Add("Название", Console.ReadLine());

        Console.WriteLine("Введите дату создания записи:");
        record.Add("Дата", Console.ReadLine());

        Console.WriteLine("Введите важность записи:");
        record.Add("Важность", Console.ReadLine());

        Console.WriteLine("Введите тип записи:");
        record.Add("Тип", Console.ReadLine());

        Console.WriteLine("Введите текст записи:");
        record.Add("Текст", Console.ReadLine());

        records.Add(key, record);

        Console.WriteLine("Запись успешно добавлена.");
    }

    static void RemoveRecord()
    {
        Console.WriteLine("Введите ключ записи, которую хотите удалить:");
        string key = Console.ReadLine();

        if (records.ContainsKey(key))
        {
            records.Remove(key);
            Console.WriteLine("Запись успешно удалена.");
        }
        else
        {
            Console.WriteLine("Запись с указанным ключом не найдена.");
        }
    }

    static void SearchByKey()
    {
        Console.WriteLine("Введите ключ записи, которую хотите найти:");
        string key = Console.ReadLine();

        if (records.ContainsKey(key))
        {
            ListDictionary record = (ListDictionary)records[key];

            Console.WriteLine("Название: " + record["Название"]);
            Console.WriteLine("Дата: " + record["Дата"]);
            Console.WriteLine("Важность: " + record["Важность"]);
            Console.WriteLine("Тип: " + record["Тип"]);
            Console.WriteLine("Текст: " + record["Текст"]);
        }
        else
        {
            Console.WriteLine("Запись с указанным ключом не найдена.");
        }
    }
}
