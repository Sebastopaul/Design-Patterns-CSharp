using System.IO;

namespace sl_app_tp_29112023;

public class Writer
{
    private readonly string _name;
    private readonly Country _country;
    private readonly IList<Genre> _genres = new List<Genre>();
    private readonly IList<Book> _books = new List<Book>();

    public Writer(string name, Country country)
    {
        var db = Database.Instance();

        var countryId = int.Parse(db.FindObjectId("SELECT id FROM country WHERE name = " + country.GetName()));
        db.AddObject("INSERT INTO writer(name, country_id) VALUES(" + name + ", " + countryId + ")");
        
        _name = name;
        _country = country;
    }

    public string GetName()
    {
        return _name;
    }

    private void AddGenre(Genre genre)
    {
        var db = Database.Instance();
        var writerId = int.Parse(db.FindObjectId("SELECT id FROM writer WHERE name = " + this.GetName()));
        var genreId = int.Parse(db.FindObjectId("SELECT id FROM genre WHERE name = " + genre.GetName()));
        
        db.AddObject("INSERT INTO writer_language(country_id, genre_id) VALUES(" + writerId + ", " + genreId + ")");
        _genres.Add(genre);
    }

    public void WriteBook(string name, string content)
    {
        _books.Add(new BookNovel(name, content, this));
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