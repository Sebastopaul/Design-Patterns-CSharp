using System.Collections.Generic;
using System.Linq;

namespace SLApp.Iterator;

public class Company: IComponent
{
    private readonly IList<IComponent> _children = new List<IComponent>();

    public void Add(IComponent component)
    {
        _children.Add(component);
    }

    public void Remove(IComponent component)
    {
        _children.Remove(component);
    }

    public IEnumerable<IComponent> GetChildren()
    {
        return _children;
    }

    public IIterator CreateIterator()
    {
        return new Iterator(this);
    }
    
    public int Execute()
    {
        return _children.Sum(component => component.Execute());
    }
}