namespace SLApp.Iterator;

public class Iterator: IIterator
{
    private readonly IComponent _collection;

    public Iterator(IComponent company)
    {
        _collection = company;
    }

    public IComponent GetNext()
    {
        return _collection;
    }

    public bool HasMore()
    {
        return false;
    }
}