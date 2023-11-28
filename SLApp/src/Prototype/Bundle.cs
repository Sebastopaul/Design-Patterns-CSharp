using System.Collections.Generic;

namespace SLApp.Prototype;

public abstract class Bundle
{
    public IList<Document> Documents { get; protected init; } = new List<Document>();
}