using System;

namespace SLApp.Decorator;

public class FormImplHtml : IFormImpl
{

  public void DrawText(string text)
  {
    Console.WriteLine("HTML : " + text);
  }

  public string ManageInputArea()
  {
    return Console.ReadLine() ?? throw new NullReferenceException();
  }
}