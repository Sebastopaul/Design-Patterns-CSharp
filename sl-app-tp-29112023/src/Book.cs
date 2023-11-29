namespace sl_app_tp_29112023;

public abstract class Book
{
    private readonly string _name;
    protected string Type;
    private readonly string _content;
    private readonly Writer _writer;

    protected Book(string name, string content, Writer writer)
    {
        _name = name;
        Type = "Book";
        _content = content;
        _writer = writer;
    }

    public string GetName()
    {
        return _name;
    }

    public string Read()
    {
        return Type + " " +_name + " written by " + _writer.GetName() + ": " + _content;
    }
}