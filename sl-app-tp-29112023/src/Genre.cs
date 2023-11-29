namespace sl_app_tp_29112023;

public class Genre: BookComponent
{
    protected Genre(string name): base(name)
    {
        Database.Instance().AddObject("INSERT INTO genre(name) VALUES(" + name + ")");
    }
}