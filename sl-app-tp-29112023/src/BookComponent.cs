namespace sl_app_tp_29112023;

public class BookComponent
{
    private readonly string _name;

    protected BookComponent(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }
}