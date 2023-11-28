namespace SLApp.AbstractFactory;

public abstract class Car
{
    protected readonly string Model;
    protected readonly string Color;
    protected readonly int Power;
    protected readonly double Space;

    protected Car(string model, string color, int power, double space)
    {
        Model = model;
        Color = color;
        Power = power;
        Space = space;
    }

    public abstract string GetSpecifications();
}