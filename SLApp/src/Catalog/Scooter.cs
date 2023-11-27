namespace SLApp.Catalog;

public abstract class Scooter
{
    protected readonly string Model;
    protected readonly string Color;
    protected readonly int Power;

    protected Scooter(string model, string color, int
        power)
    {
        Model = model;
        Color = color;
        Power = power;
    }
    public abstract string GetSpecifications();
}