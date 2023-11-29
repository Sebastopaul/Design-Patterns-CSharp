namespace sl_app_tp_29112023;

public class Book
{
    private readonly string _name;
    private readonly string _content;
    private readonly Writer _writer;

    public Book(string name, string content, Writer writer)
    {
        _name = name;
        _content = content;
        _writer = writer;
    }

    public string GetName()
    {
        return _name;
    }

    public string Read()
    {
        return _name + " written by " + _writer.GetName() + ": " + _content;
    }
}