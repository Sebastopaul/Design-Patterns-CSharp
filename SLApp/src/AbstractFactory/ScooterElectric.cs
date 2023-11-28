namespace SLApp.AbstractFactory;

internal class ScooterElectric: Scooter
{
    public ScooterElectric(string model, string color, int power) : base(model, color, power) {}

    public override string GetSpecifications()
    {
        return "Electric scooter, model : " + Model + ", color : " + Color + ", power : " + Power;
    }
}