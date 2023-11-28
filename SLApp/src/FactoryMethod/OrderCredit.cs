using System;

namespace SLApp.FactoryMethod;

public class OrderCredit : Order
{
  public OrderCredit(double amount) : base(amount){}

  public override void Pay()
  {
    Console.WriteLine(
      "The order is paid to the credit of " + Amount);
  }

  public override bool Valid()
  {
    return Amount is >= 1000.0 and <= 5000.0;
  }
}
