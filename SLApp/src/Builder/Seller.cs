namespace SLApp.Builder;

public class Seller
{
  private BuilderVehicleBundle Builder;

  public Seller(BuilderVehicleBundle builder)
  {
    Builder = builder;
  }

  public Bundle Build(string customerName)
  {
    Builder.BuildOrderForm(customerName);
    Builder.BuildRegistrationRequest(customerName);
    
    var bundle = Builder.Result();
    return bundle;
  }
}
