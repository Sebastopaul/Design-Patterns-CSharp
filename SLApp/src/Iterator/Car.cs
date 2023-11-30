using System.Collections;
using System.Collections.Generic;

namespace SLApp.Iterator;

public class Car: IComponent
{
    public IIterator CreateIterator()
    {
        return new Iterator(this);
    }
    
    public IEnumerable<IComponent> GetChildren()
    {
        return new List<IComponent>();
    }
    
    public int Execute()
    {
        return 1;
    }
}