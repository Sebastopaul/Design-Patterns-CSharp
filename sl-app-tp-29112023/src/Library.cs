namespace sl_app_tp_29112023;

public class Library
{
    private readonly string _name;
    private IList<Book> _books = new List<Book>();

    private static Library? _instance = null;

    private Library(string name)
    {
        _name = name;
    }

    public static Library Instance(string name)
    {
        return _instance ??= new Library(name);
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