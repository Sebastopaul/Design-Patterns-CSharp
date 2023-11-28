namespace SLApp.Factory;

public static class User
{
  public static void Run()
  {
    Customer customer = new CustomerCash();
    customer.NewOrder(2000.0);
    customer.NewOrder(10000.0);
    customer = new CustomerCredit();
    customer.NewOrder(2000.0);
    customer.NewOrder(10000.0);
  }
}
