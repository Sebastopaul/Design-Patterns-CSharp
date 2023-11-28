namespace SLApp.AbstractFactory;

public class CreateVehicleElectric : ICreateVehicle
{
    public Car CreateCar(string model, string color, int power, double space)
    {
        return new CarElectric(model, color, power, space);
    }

    public Scooter CreateScooter(string model, string color, int power)
    {
        return new ScooterElectric(model, color, power);
    }
}