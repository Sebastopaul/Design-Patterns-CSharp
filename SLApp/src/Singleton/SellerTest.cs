namespace SLApp.Singleton;

public class SellerTest
{
  static void Run()
  {
    var seller = Seller.Instance();
    seller.Name = "Seller Auto";
    seller.Address = "Paris";
    seller.Email = "vendeur@vendeur.com";
    Display();
  }

  private static void Display()
  {
    var seller = Seller.Instance();
    seller.Display();
  }
}