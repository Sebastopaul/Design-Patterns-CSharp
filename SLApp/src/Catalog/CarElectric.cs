namespace SLApp.Catalog;

public class CarElectric : Car
{
    public CarElectric(string model, string color, int power, double space) : base(model, color, power, space) {}

    public override string GetSpecifications()
    {
        return "Electric car, model : " + Model + ", color : " + Color + ", power : " + Power + ", space : " + Space;
    }
}