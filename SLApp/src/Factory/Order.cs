namespace SLApp.Factory;

public abstract class Order
{
  protected readonly double Amount;

  protected Order(double amount)
  {
    this.Amount = amount;
  }

  public abstract bool Valid();

  public abstract void Pay();
}
