namespace sl_app_tp_29112023;

public class Library
{
    private readonly string _name;
    private readonly IList<Book> _books = new List<Book>();

    private static Library? _instance = null;

    private Library(string name)
    {
        _name = name;
    }

    public static Library Instance(string name)
    {
        return _instance ??= new Library(name);
    }

    public int Run()
    {
        Console.WriteLine("Welcome to " + _name + " library !");
        while (Console.ReadLine() != "exit")
        {
            Console.WriteLine("Are you looking for a writer (1), a genre (2), a release date (3), a specific language (4), or an area (5) ?");
        }

        return 0;
    }

    public string GetName()
    {
        return _name;
    }

    public void AddBook(Book book)
    {
        _books.Add(book);
    }

    public void RemoveBook(Book book)
    {
        _books.Remove(book);
    }
}