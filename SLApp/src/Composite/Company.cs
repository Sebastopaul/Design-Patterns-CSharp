using System.Collections.Generic;
using System.Linq;

namespace SLApp.Composite;

public class Company
{
    private IList<Company> _subsidiaries = new List<Company>();
    private IList<Car> _cars = new List<Car>();
    
    public void AddSubsidiary(Company subsidiary)
    {
        _subsidiaries.Add(subsidiary);
    }
    
    public void AddCar(Car car)
    {
        _cars.Add(car);
    }
    
    public int CountCars()
    {
        return _cars.Count + _subsidiaries.Sum(subsidiary => subsidiary.CountCars());
    }
}