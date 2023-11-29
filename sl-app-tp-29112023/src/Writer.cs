using System.IO;

namespace sl_app_tp_29112023;

public abstract class Writer
{
    private readonly string _name;
    private readonly Country _country;
    private readonly IList<Genre> _genres = new List<Genre>();
    protected readonly IList<Book> Books = new List<Book>();
    private readonly IList<Customer> _subscribers = new List<Customer>();

    protected Writer(string name, Country country)
    {
        //var db = Database.Instance();

        //var countryId = int.Parse(db.FindObjectId("SELECT id FROM country WHERE name = " + country.GetName()));
        //db.AddObject("INSERT INTO writer(name, country_id) VALUES(" + name + ", " + countryId + ")");
        
        _name = name;
        _country = country;
    }

    public string GetName()
    {
        return _name;
    }

    protected void AddGenre(Genre genre)
    {
        //var db = Database.Instance();
        //var writerId = int.Parse(db.FindObjectId("SELECT id FROM writer WHERE name = " + GetName()));
        //var genreId = int.Parse(db.FindObjectId("SELECT id FROM genre WHERE name = " + genre.GetName()));
        //
        //db.AddObject("INSERT INTO writer_genre(country_id, genre_id) VALUES(" + writerId + ", " + genreId + ")");
        genre.AddWriter(this);
        _genres.Add(genre);
    }

    public abstract Book WriteBook(string name, string content, Genre genre, Language language);

    protected bool HasWrittenGenre(BookComponent genre)
    {
        return _genres.Any(savedGenre => savedGenre.GetName() == genre.GetName());
    }

    private void NotifySubscribers(Book book)
    {
        foreach (var subscriber in _subscribers)
        {
            subscriber.Notify(this, book);
        }
    }

    public void Subscribe(Customer subscriber)
    {
        if (!_subscribers.Contains(subscriber))
        {
            _subscribers.Add(subscriber);
        }
    }
    
    public Book GetBook(string name)
    {
        foreach (var book in Books)
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