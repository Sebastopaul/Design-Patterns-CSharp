namespace sl_app_tp_29112023;

public class BookNovel: Book
{
    public BookNovel(string name, string content, Writer writer): base(name, content, writer)
    {
        Type = "Novel";
    }
}