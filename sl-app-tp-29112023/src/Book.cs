namespace sl_app_tp_29112023;

public abstract class Book
{
    protected readonly string Name;
    protected readonly string Content;
    protected readonly Writer Writer;
    protected readonly Language Language;
    protected readonly Genre Genre;

    protected Book(string name, string content, Writer writer, Language language, Genre genre)
    {
        //var db = Database.Instance();
        //var writerId = int.Parse(db.FindObjectId("SELECT id FROM writer WHERE name = " + writer.GetName()));
        //var languageId = int.Parse(db.FindObjectId("SELECT id FROM language WHERE name = " + language.GetName()));
        //var genreId = int.Parse(db.FindObjectId("SELECT id FROM genre WHERE name = " + genre.GetName()));
        //db.AddObject("INSERT INTO book(name, type, content, language_id, writer_id, genre_id) VALUES("
        //             + name + ", novel, " + content + ", " + languageId + ", " + writerId + ", " + genreId +")");

        Name = name;
        Content = content;
        Writer = writer;
        Language = language;
        Genre = genre;
    }

    public string GetName()
    {
        return Name;
    }

    public abstract string Read();
}