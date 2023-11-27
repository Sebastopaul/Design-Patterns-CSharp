namespace SLApp;

public sealed class Catalog
{
    private static readonly Lazy<Catalog> _lazy = new Lazy<Catalog>(() => new Catalog());
    
    public static Catalog Instance { get { return _lazy.Value; } }

    private Catalog()
    {
    }
}