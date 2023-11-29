namespace sl_app_tp_29112023;

public class Library
{
    private readonly string _name;
    private readonly IList<Book> _books = new List<Book>();

    private static Library? _instance;

    private Library(string name)
    {
        _name = name;
        
        var france = new Country("France");
        var england = new Country("England");
        var usa = new Country("USA");
        var poland = new Country("Poland");

        var english = new Language("english");
        var french = new Language("french");
        var polish = new Language("polish");

        france.AddLanguage(french);
        france.AddLanguage(english);
        england.AddLanguage(english);
        usa.AddLanguage(english);
        poland.AddLanguage(english);
        poland.AddLanguage(polish);

        var thriller = new Genre("thriller");
        var romance = new Genre("romance");
        var comedy = new Genre("comedy");

        var rowling = new NovelWriter("Rowling", england);
        var lovecraft = new NovelWriter("Lovecraft", usa);
        var sapkowski = new NovelWriter("Sapkowski", poland);

        var potter = rowling.WriteBook("Harry Potter", "Expeliarmus lmao", romance, english);
        var frenchPotter = rowling.WriteBook("Harry Potter", "Expeliarmus lmao", romance, french);
        var beast = rowling.WriteBook("Magic Beasts", "Magic bark lul", comedy, english);
        var witcher = sapkowski.WriteBook("The Witcher", "Git gud", thriller, polish);
        var cthulhu = lovecraft.WriteBook("Cthulhu Myth", "U mad bro ?", thriller, english);
        var dagon = lovecraft.WriteBook("Dagon Myth", "U mad bro ?", thriller, english);
        var azatoth = lovecraft.WriteBook("Azatoth Myth", "U mad bro ?", thriller, english);

        _books.Add(potter);
        _books.Add(frenchPotter);
        _books.Add(beast);
        _books.Add(witcher);
        _books.Add(cthulhu);
        _books.Add(dagon);
        _books.Add(azatoth);
    }

    public static Library Instance(string name)
    {
        return _instance ??= new Library(name);
    }

    public int Run(Customer customer)
    {
        Console.WriteLine("Welcome to " + _name + " library !");
        Console.WriteLine("Are you looking for a writer (1) or a book (2) ?");
        

        return 0;
    }
}