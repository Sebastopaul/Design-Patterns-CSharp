﻿using System.Collections.Generic;
using System.Linq;

namespace SLApp.Composite;

public class Company
{
    private readonly IList<Company> _subsidiaries = new List<Company>();
    private int _cars;

    public Company(int cars)
    {
        _cars = cars;
    }
    
    public void AddSubsidiary(Company subsidiary)
    {
        _subsidiaries.Add(subsidiary);
    }

    public void AddCar()
    {
        _cars++;
    }
    
    public int CountCars()
    {
        return _cars + _subsidiaries.Sum(subsidiary => subsidiary.CountCars());
    }
}