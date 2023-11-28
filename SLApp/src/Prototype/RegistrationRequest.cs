using System;

namespace SLApp.Prototype;

public class RegistrationRequest : Document
{
  public override void Display()
  {
    Console.WriteLine("Display the registration request : " + Content);
  }

  public override void Print()
  {
    Console.WriteLine("Print the registration request : " + Content);
  }
}