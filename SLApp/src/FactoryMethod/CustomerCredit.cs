namespace SLApp.FactoryMethod;

public class CustomerCredit : Customer
{
  protected override Order CreateOrder(double amount)
  {
    return new OrderCredit(amount);
  }
}
