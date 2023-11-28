namespace SLApp.Builder;

public class BuilderVehicleBundleHtml :
  BuilderVehicleBundle
{
  public BuilderVehicleBundleHtml()
  {
    Bundle = new BundleHtml();
  }

  public override void BuildOrderForm(string customerName)
  {
    var document = "<HTML>Customer order form : " + customerName + "</HTML>";
    Bundle.AddDocument(document);
  }

  public override void BuildRegistrationRequest(string applicantName)
  {
    var document = "<HTML>Applicant registration request : " + applicantName + "</HTML>";
    Bundle.AddDocument(document);
  }
}
