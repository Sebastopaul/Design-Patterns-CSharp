namespace SLApp.Catalog;

public class CreateVehicleOil : ICreateVehicle
{
    public Car CreateCar(string model, string color, int power, double space)
    {
        return new CarOil(model, color, power, space);
    }

    public Scooter CreateScooter(string model, string color, int power)
    {
        return new ScooterOil(model, color, power);
    }
}