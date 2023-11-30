using System;

namespace SLApp.Iterator;

public interface IComponent
{
    public IIterator CreateIterator();
    public void Execute();
}