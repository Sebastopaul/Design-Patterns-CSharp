using System;

namespace SLApp.VehicleCustomer;

public class BundlePdf : Bundle
{
  public override void AddDocument(string document)
  {
    if (document.StartsWith("<PDF>"))
      Content.Add(document);
  }

  public override void Print()
  {
    Console.WriteLine("Bundle PDF");
    foreach (var s in Content)
      Console.WriteLine(s);
  }
}
