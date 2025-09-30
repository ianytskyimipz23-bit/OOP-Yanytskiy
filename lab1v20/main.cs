// "Рецепт" для створення книг
public class Book
{
    public string title;
    public string author;
    public int Year { get; set; }

    // Конструктор
    public Book(string bookTitle, string bookAuthor, int bookYear)
    {
        title = bookTitle;
        author = bookAuthor;
        Year = bookYear;
        Console.WriteLine($"Створено книгу: '{title}'");
    }

    // Деструктор
    ~Book()
    {
        Console.WriteLine($" Книгу '{title}' видалено.");
    }

    // Метод
    public string GetInfo()
    {
        return $"Книга '{title}', автор {author}, рік видання {Year}.";
    }
}

// Головна частина програми
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Створюємо об'єкти
        Book book1 = new Book("Кобзар", "Тарас Шевченко", 1840);
        Book book2 = new Book("Захар Беркут", "Іван Франко", 1883);

        Console.WriteLine("\n--- Інформація про книги ---");

        // Виводимо результат
        Console.WriteLine(book1.GetInfo());
        Console.WriteLine(book2.GetInfo());
    }
}