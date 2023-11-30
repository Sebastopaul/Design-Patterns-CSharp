using System.Collections.Generic;
using System.Linq;

namespace SLApp.Iterator;

public class Iterator: IIterator
{
    private readonly IComponent _collection;
    private readonly IList<IComponent> _state = new List<IComponent>();

    public Iterator(IComponent company)
    {
        _collection = company;
        _state.Add(company);
    }

    public IComponent GetNext()
    {
        if (!HasMore())
            throw new KeyNotFoundException();

        var current = _state.First();
        _state.Remove(current);

        foreach (var child in current.GetChildren())
        {
            _state.Add(child);
        }

        return current;
    }

    public bool HasMore()
    {
        return _state.Count != 0;
    }
}