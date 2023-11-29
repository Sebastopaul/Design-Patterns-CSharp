namespace sl_app_tp_29112023;

public class Genre: BookComponent
{
    private readonly IList<Writer> _writers = new List<Writer>();

    public Genre(string name): base(name)
    {
        Database.Instance().AddObject("INSERT INTO genre(name) VALUES(" + name + ")");
    }

    public void AddWriter(Writer writer)
    {
        _writers.Add(writer);
    }
}