using System;

namespace SLApp.Singleton;

public class Seller
{
  public string Name { get; set; } = "";
  public string Address { get; set; } = "";
  public string Email { get; set; } = "";

  private static Seller? _instance = null;

  private Seller() {}

  public static Seller Instance()
  {
    return _instance ??= new Seller();
  }

  public void Display()
  {
    Console.WriteLine("Name : " + Name);
    Console.WriteLine("Address : " + Address);
    Console.WriteLine("Email : " + Email);
  }

}