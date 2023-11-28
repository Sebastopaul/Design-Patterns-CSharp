using System.Collections.Generic;
using System.Linq;

namespace SLApp.Composite;

public class Company
{
    private readonly IList<Company> _subsidiaries = new List<Company>();
    private readonly IList<Car> _cars = new List<Car>();

    public Company(int cars)
    {
        for (var i = 0; i < cars; i++)
        {
            _cars.Add(new Car());
        }
    }
    
    public void AddSubsidiary(Company subsidiary)
    {
        _subsidiaries.Add(subsidiary);
    }
    
    public int CountCars()
    {
        return _cars.Count + _subsidiaries.Sum(subsidiary => subsidiary.CountCars());
    }
}