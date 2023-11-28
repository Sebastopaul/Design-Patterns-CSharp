namespace SLApp.AbstractFactory;

public class CarOil: Car
{
    public CarOil(string model, string color, int power, double space) : base(model, color, power, space) {}

    public override string GetSpecifications()
    {
        return "Oil car, model : " + Model + ", color : " + Color + ", power : " + Power + ", space : " + Space;
    }
}