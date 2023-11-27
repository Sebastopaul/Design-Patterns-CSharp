using System.Collections.Generic;

namespace SLApp.VehicleCustomer;

public abstract class Bundle
{
  protected readonly IList<string> Content = new List<string>();

  public abstract void AddDocument(string document);
  public abstract void Print();
}
