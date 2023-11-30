using System.Collections.Generic;

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

    public IList<IComponent> GetChildren()
    {
        return _children;
    }

    public IIterator CreateIterator()
    {
        return new Iterator(this);
    }
    
    public void Execute()
    {
        foreach (var component in _children)
        {
            component.Execute();
        }
    }
}