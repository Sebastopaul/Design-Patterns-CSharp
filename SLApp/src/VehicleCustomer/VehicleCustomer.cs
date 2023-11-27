using System;

namespace SLApp.VehicleCustomer;

public static class VehicleCustomer
{
  public static int Run()
  {
    BuilderVehicleBundle builder;
    Console.WriteLine("Do you want to build HTML bundles (1) or PDF bundles (2) ? ");
    
    var choice = Console.ReadLine();
    if (choice == "1")
      builder = new BuilderVehicleBundleHtml();
    else
      builder = new BuilderVehicleBundlePdf();
    
    var seller = new Seller(builder);
    var bundle = seller.Build("Martin");
    bundle.Print();

    return 0;
  }
}
