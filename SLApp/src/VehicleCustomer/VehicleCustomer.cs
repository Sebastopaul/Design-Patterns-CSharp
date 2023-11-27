using System;

namespace SLApp.VehicleCustomer;

public static class VehicleCustomer
{
  private const string BadChoice = "Incorrect choice";

  public static int Run()
  {
    BuilderVehicleBundle builder;
    
    string? choice = null;
    for (choice = ""; choice != "1" && choice != "2";)
    {
      Console.WriteLine("Do you want to build HTML bundles (1) or PDF bundles (2) ? ");
      choice = Console.ReadLine();
      if (choice != "1" && choice != "2") {
        Console.WriteLine(BadChoice);
      }
    }
    
    if (choice == "1")
      builder = new BuilderVehicleBundleHtml();
    else
      builder = new BuilderVehicleBundlePdf();
    
    var seller = new Seller(builder);
    try {
      var bundle = seller.Build("Martin");
      bundle.Print();
    } catch (NullReferenceException e) {
      Console.WriteLine(e.Message);
      return 1;
    }

    return 0;
  }
}
