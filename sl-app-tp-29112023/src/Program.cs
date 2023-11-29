namespace sl_app_tp_29112023;

internal static class Program
{
    public static int Main(string[] args)
    {
        var library = Library.Instance("Shields and Potatoes");

        Console.WriteLine("Please enter your name before entering the library : ");
        var name = Console.ReadLine();

        return library.Run(new Customer(name ?? throw new NullReferenceException("Error entering your name.")));
    }
}
