using System.Collections.Generic;

namespace SLApp.Prototype;

public class BundleCustomer : Bundle
{
  public BundleCustomer(string infos)
  {
    Documents = new List<Document>();
    var blankBundle = BundleBlank.Instance();
    var blankDocs = blankBundle.Documents;
    foreach (var document in blankDocs) {
      var docCopy = document.Duplicate();
      docCopy.Fill(infos);
      Documents.Add(docCopy);
    }
  }

  public void Display()
  {
    foreach (var document in Documents)
      document.Display();
  }

  public void Print()
  {
    foreach (var document in Documents)
      document.Print();
  }
}