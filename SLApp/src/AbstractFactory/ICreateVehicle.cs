namespace SLApp.AbstractFactory;

public interface ICreateVehicle
{
    Car CreateCar(string model, string color, int power, double space);
    Scooter CreateScooter(string model, string color, int power);
}