namespace SLApp {
    public static class Catalog
    {
        public static int Main(string[] args)
        {
            if (args.Length < 2) {
                Console.WriteLine("Usage: Catalog.exe <vehicule> <type> [number=1]");
                return -1;
            }

            number = 1;

            if (args.Length == 3) {
                number = int.Parse(args[2]);
            }

            switch (args[1]) {
                case "Elec":
                    factory = new FabriqueVehiculeElectrique();
                    break;
                case "Ess":
                    factory = new FabriqueVehiculeEssence();
                    break;
                default:
                    Console.WriteLine("Usage: Catalog.exe <vehicule=A|S> <type=Elec|Ess> [number=1]");
                    return -1;
            }

            if (args[0] != "A" && args[0] != "S") {
                Console.WriteLine("Usage: Catalog.exe <vehicule=A|S> <type=Elec|Ess> [number=1]");
                return -1;
            }

            if (args[0] == "A") {
                for (int i = 0; i < number; i++) {
                    automobile = factory.creerAutomobile();
                    Console.WriteLine(automobile.getName());
                }
                return 0;
            } 
            for (int i = 0; i < number; i++) {
                scooter = factory.creerScooter();
                Console.WriteLine(scooter.getName());
            }
            return 0;
        }
    }
}
