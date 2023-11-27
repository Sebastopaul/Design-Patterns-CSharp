namespace SLApp.Catalog;

public class ScooterOil : Scooter
{
    public ScooterOil(string model, string color, int power) : base(model, color, power) {}

    public override string GetSpecifications()
    {
        return "Oil scooter, model : " + Model + ", color : " + Color + ", power : " + Power;
    }

}