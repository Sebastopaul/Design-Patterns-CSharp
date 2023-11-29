using System.IO;

namespace sl_app_tp_29112023;

public class Writer
{
    private readonly string _name;
    private readonly IList<Book> _books = new List<Book>();

    public Writer(string name, int countryId)
    {
        Database.Instance().AddObject("INSERT INTO writer(name, country_id) VALUES(" + name + ", " + countryId + ")");
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