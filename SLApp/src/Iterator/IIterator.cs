namespace SLApp.Iterator;

public interface IIterator
{
    public IComponent GetNext();
    public bool HasMore();
}