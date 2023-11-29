namespace sl_app_tp_29112023;

internal static class Program
{
    public static void Main(string[] args)
    {
        var library = Library.Instance("Shields and Potatoes");
        
        Console.WriteLine("Welcome to " + library.GetName() + " library !");
        while (Console.ReadLine() != "exit")
        {
            Console.WriteLine("Are you looking for a writer (1), a genre (2), a release date (3), a specific language (4), or an area (5) ?");
        }
    }
}
