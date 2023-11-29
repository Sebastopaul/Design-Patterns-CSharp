namespace sl_app_tp_29112023;

public class BookNovel: Book
{
    public BookNovel(string name, string content, Writer writer, Language language, Genre genre):
        base(name, content, writer, language, genre)
    {
    }

    public override string Read()
    {
        return "Novel " + Name + " written by " + Writer.GetName() + " from " + Writer.GetCountry().GetName() +
               ", written in " + Language.GetName() + ", genre " + Genre.GetName() + ": " + Content;
    }
}