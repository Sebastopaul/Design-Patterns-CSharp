using System;

namespace SLApp.Bridge;

public class FormImplApplet : IFormImpl
{

  public void DrawText(string text)
  {
    Console.WriteLine("Applet : " + text);
  }

  public string ManageInputArea()
  {
    return Console.ReadLine() ?? throw new NullReferenceException();
  }
}