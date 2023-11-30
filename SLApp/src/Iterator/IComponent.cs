using System;
using System.Collections.Generic;

namespace SLApp.Iterator;

public interface IComponent
{
    public IIterator CreateIterator();
    public IEnumerable<IComponent> GetChildren();
    public int Execute();
}