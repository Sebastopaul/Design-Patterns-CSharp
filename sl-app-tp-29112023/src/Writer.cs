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
        var writerId = int.Parse(db.FindObjectId("SELECT id FROM writer WHERE name = " + GetName()));
        var genreId = int.Parse(db.FindObjectId("SELECT id FROM genre WHERE name = " + genre.GetName()));
        
        db.AddObject("INSERT INTO writer_genre(country_id, genre_id) VALUES(" + writerId + ", " + genreId + ")");
        genre.AddWriter(this);
        _genres.Add(genre);
    }

    public void WriteBook(string name, string content, Genre genre, Language language)
    {
        if (! HasWrittenGenre(genre))
            AddGenre(genre);
        if (!_country.IsLanguageUsed(language))
            throw new KeyNotFoundException("This language is spoken in this country.");
        _books.Add(new BookNovel(name, content, this, language, genre));
    }

    private bool HasWrittenGenre(BookComponent genre)
    {
        return _genres.Any(savedGenre => savedGenre.GetName() == genre.GetName());
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

    public Country GetCountry()
    {
        return _country;
    }
}