using System;

namespace SLApp.VehicleCustomer;

public class BundleHtml : Bundle
{
  public override void AddDocument(string document)
  {
    if (document.StartsWith("<HTML>"))
      Content.Add(document);
  }

  public override void Print()
  {
    Console.WriteLine("Bundle HTML");
    foreach (var s in Content)
      Console.WriteLine(s);
  }
}
