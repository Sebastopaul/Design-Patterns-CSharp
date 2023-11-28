using System;

namespace SLApp.Prototype;

public class OrderForm : Document
{
  public override void Display()
  {
    Console.WriteLine("Display the order form : " + Content);
  }

  public override void Print()
  {
    Console.WriteLine("Print the order form : " + Content);
  }
}