using System;

namespace SLApp.Prototype;

public class TransferCertificate : Document
{
  public override void Display()
  {
    Console.WriteLine("Display the transfer certificate : " + Content);
  }

  public override void Print()
  {
    Console.WriteLine("Print the transfer certificate : " + Content);
  }
}