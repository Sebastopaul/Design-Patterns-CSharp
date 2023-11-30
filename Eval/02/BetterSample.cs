using System;

// Poorly designed class without singleton pattern
class Singleton
{
    private static Singleton _singleton;
    public static int InstanceCount;

    private Singleton()
    {
        InstanceCount++;
    }

    public static Singleton GetInstance()
    {
        if (_singleton == null)
            _singleton = new Singleton();
        return _singleton;
    }
}

// Client code
class Program
{
    static void Main(string[] args)
    {
        Singleton instance1 = Singleton.GetInstance();
        Console.WriteLine(Singleton.InstanceCount); // Output: 1

        Singleton instance2 = Singleton.GetInstance();
        Console.WriteLine(Singleton.InstanceCount); // Output: 1

        Singleton instance3 = Singleton.GetInstance();
        Console.WriteLine(Singleton.InstanceCount); // Output: 1

        Singleton instance4 = Singleton.GetInstance();
        Console.WriteLine(Singleton.InstanceCount); // Output: 1

        Singleton instance5 = Singleton.GetInstance();
        Console.WriteLine(Singleton.InstanceCount); // Output: 1
    }
}