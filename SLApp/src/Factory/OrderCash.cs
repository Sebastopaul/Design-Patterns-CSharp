using System;

namespace SLApp.Factory;

public class OrderCash : Order
{
  public OrderCash(double amount) : base(amount){}

  public override void Pay()
  {
    Console.WriteLine(
      "Payment for the order of " + Amount + " is made in cash.");
  }

  public override bool Valid()
  {
    return true;
  }
}
