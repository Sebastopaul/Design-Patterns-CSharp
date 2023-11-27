using System;

namespace SLApp.Catalog;

public static class Catalog
{
    private const string BadChoice = "Incorrect choice";
    public static int Run()
    {
        ICreateVehicle factory;

        string? choice = null;
            
        for (choice = ""; choice != "1" && choice != "2";)
        {
            Console.WriteLine("Do you want to use electric vehicles (1) or oil vehicles (2) ? ");
            choice = Console.ReadLine();
            if (choice != "1" && choice != "2") {
                Console.WriteLine(BadChoice);
            }
        }
            
        switch (choice) {
            case "1":
                factory = new CreateVehicleElectric();
                break;
            default :
                factory = new CreateVehicleOil();
                break;
        }
            
        for (choice = ""; choice != "1" && choice != "2";)
        {
            Console.WriteLine("Do you want cars (1) or scooters (2) ? ");
            choice = Console.ReadLine();
            if (choice != "1" && choice != "2") {
                Console.WriteLine(BadChoice);
            }
        }
            
        int number;
        for (number = 0; number < 1 || number > 5;) {
            Console.WriteLine("How many vehicles do you want (1-5) ? ");
            number = int.Parse(Console.ReadLine() ?? "");
            if (number < 1 || number > 5) {
                Console.WriteLine(BadChoice);
            }
        }

        if (choice == "1") {
            for (var i = 0; i < number; i++) {
                var car = factory.CreateCar("standard", "yellow", 6+i, 3.2);
                Console.WriteLine(car.GetSpecifications());
            }
            return 0;
        }

        for (var i = 0; i < number; i++) {
            var scooter = factory.CreateScooter("classic", "red", 2+i);
            Console.WriteLine(scooter.GetSpecifications());
        }
        return 0;
    }
}