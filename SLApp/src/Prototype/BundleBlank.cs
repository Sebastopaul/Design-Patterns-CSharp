using System.Collections.Generic;

namespace SLApp.Prototype;

public class BundleBlank : Bundle
{
  private static BundleBlank? _instance = null;

  private BundleBlank()
  {
    Documents = new List<Document>();
  }

  public static BundleBlank Instance()
  {
    return _instance ??= new BundleBlank();
  }

  public void Add(Document doc)
  {
    Documents.Add(doc);
  }

  public void Remove(Document doc)
  {
    Documents.Remove(doc);
  }
}