using System.Collections.Generic;

namespace SLApp.Factory;

public abstract class Customer
{
  private IList<Order> Orders = new List<Order>();
  
  protected abstract Order CreateOrder(double amount);

  public void NewOrder(double amount)
  {
    var order = this.CreateOrder(amount);
    if (! order.Valid()) {
      return;
    }
    order.Pay();
    Orders.Add(order);
  }
}
