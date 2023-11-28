namespace SLApp.Prototype;

public abstract class Document
{
  protected string Content = "";

  public Document Duplicate()
  {
    var result = (Document) this.MemberwiseClone();
    return result;
  }

  public void Fill(string infos)
  {
    Content = infos;
  }

  public abstract void Print();
  public abstract void Display();
}