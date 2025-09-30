using System.Collections.Generic;
using System;

// Клас, що імітує словник
public class MyDictionary
{
    // 1. Приватні поля (інкапсуляція)
    private List<string> keys = new List<string>();
    private List<string> values = new List<string>();

    // 2. Індексатор для доступу за ключем
    public string this[string key]
    {
        get
        {
            int index = keys.IndexOf(key);
            return (index != -1) ? values[index] : "Ключ не знайдено";
        }
        set
        {
            int index = keys.IndexOf(key);
            if (index != -1)
            {
                values[index] = value; // Оновити існуючий
            }
            else
            {
                keys.Add(key); // Додати новий
                values.Add(value);
            }
        }
    }

    // 3. Перевантаження оператора '+' для об'єднання словників
    public static MyDictionary operator +(MyDictionary dict1, MyDictionary dict2)
    {
        MyDictionary newDict = new MyDictionary();
        for (int i = 0; i < dict1.keys.Count; i++)
        {
            newDict[dict1.keys[i]] = dict1.values[i];
        }
        for (int i = 0; i < dict2.keys.Count; i++)
        {
            newDict[dict2.keys[i]] = dict2.values[i];
        }
        return newDict;
    }

    // Допоміжний метод для виведення вмісту
    public void Print()
    {
        Console.WriteLine("--- Вміст словника ---");
        for (int i = 0; i < keys.Count; i++)
        {
            Console.WriteLine($"'{keys[i]}' : '{values[i]}'");
        }
        Console.WriteLine("-----------------------");
    }
}

// Головний клас програми
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // 4. Демонстрація роботи
        MyDictionary dict1 = new MyDictionary();
        dict1["cat"] = "кіт";
        dict1["dog"] = "собака";
        Console.WriteLine("Словник 1:");
        dict1.Print();

        MyDictionary dict2 = new MyDictionary();
        dict2["sun"] = "сонце";
        dict2["dog"] = "пес"; // Оновить значення для ключа "dog"
        Console.WriteLine("\nСловник 2:");
        dict2.Print();

        Console.WriteLine("\nОб'єднаний словник (dict1 + dict2):");
        MyDictionary combined = dict1 + dict2;
        combined.Print();

        Console.WriteLine($"\nЗначення за ключем 'cat': {combined["cat"]}");
    }
}