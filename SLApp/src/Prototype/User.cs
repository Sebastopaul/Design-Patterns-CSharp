namespace SLApp.Prototype;

public class User
{
  static void Run()
  {
    var bundleBlank = BundleBlank.Instance();
    bundleBlank.Add(new OrderForm());
    bundleBlank.Add(new TransferCertificate());
    bundleBlank.Add(new RegistrationRequest());
    var bundleClient1 = new BundleCustomer("Martin");
    var bundleClient2 = new BundleCustomer("Durant");
    bundleClient1.Display();
    bundleClient2.Display();
  }
}