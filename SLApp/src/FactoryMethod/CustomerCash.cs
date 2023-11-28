namespace SLApp.FactoryMethod;

public class CustomerCash : Customer
{
  protected override Order CreateOrder(double amount)
  {
    return new OrderCash(amount);
  }
}
