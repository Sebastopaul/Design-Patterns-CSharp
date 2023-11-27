using System;
namespace SLApp.VehicleCustomer;

public class BuilderVehicleBundlePdf :
  BuilderVehicleBundle
{
  public BuilderVehicleBundlePdf()
  {
    Bundle = new BundlePdf();
  }

  public override void BuildOrderForm(string customerName)
  {
    var document = "<PDF>Customer order form : " + customerName + "</PDF>";
    Bundle.AddDocument(document);
  }

  public override void BuildRegistrationRequest(string applicantName)
  {
    var document = "<PDF>Applicant registration request : " + applicantName + "</PDF>";
    Bundle.AddDocument(document);
  }
}
