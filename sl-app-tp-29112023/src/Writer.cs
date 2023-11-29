using System.IO;

namespace sl_app_tp_29112023;

public class Writer
{
    private readonly IList<Book> _books = new List<Book>();
    private readonly string _name;

    public Writer(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public void WriteBook(string name, string content)
    {
        _books.Add(new Book(name, content, this));
    }
    
    public Book GetBook(string name)
    {
        foreach (var book in _books)
        {
            if (book.GetName() == name)
                return book;
        }

        throw new KeyNotFoundException("Writer " + _name + " hasn't written the book " + name + '.');
    }
}