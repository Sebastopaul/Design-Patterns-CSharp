namespace sl_app_tp_29112023;

internal static class Customer
{
    public static void Main(string[] args)
    {
        var library = Library.Instance("Shields and Potatoes");
        
        Console.WriteLine("Welcome to " + library.GetName() + " library !");
        while (Console.ReadLine() != "exit")
        {
            
        }
    }
}
