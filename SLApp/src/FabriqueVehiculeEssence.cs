namespace SLApp;
class FabriqueVehicule
{
    public Automobile creeAutomobile()
    {
        return new AutomobileElectrique("Automobile électrique");
    }

    public Scooter creeScooter()
    {
        return new ScooterElectrique("Scooter électrique");
    }
}