using System;
namespace SLApp.VehicleCustomer;

public abstract class BuilderVehicleBundle
{
  protected Bundle? Bundle = null;

  public abstract void BuildOrderForm(string customerName);

  public abstract void BuildRegistrationRequest(string applicantName);

  public Bundle Result()
  {
    if (Bundle == null)
      throw new Exception("Bundle is null");
    
    return Bundle;
  }
}
