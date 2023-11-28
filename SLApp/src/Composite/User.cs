using System;
using System.Text;

namespace SLApp.Composite;

public static class User
{
    public static int Run()
    {
        var company1 = new Company(5);
        var company2 = new Company(6);
        var company3 = new Company(2);
        var mainCompany = new Company(4);
        
        company1.AddSubsidiary(new Company(8));
        company1.AddSubsidiary(new Company(7));
        company1.AddSubsidiary(new Company(9));
        company2.AddSubsidiary(new Company(6));
        company2.AddSubsidiary(new Company(3));
        company2.AddSubsidiary(new Company(1));
        company3.AddSubsidiary(new Company(0));
        company3.AddSubsidiary(new Company(2));
        company3.AddSubsidiary(new Company(4));
        mainCompany.AddSubsidiary(company1);
        mainCompany.AddSubsidiary(company2);
        mainCompany.AddSubsidiary(company3);
        
        Console.WriteLine(5+6+2+4+8+7+9+6+3+1+0+2+4);
        Console.WriteLine("There are " + mainCompany.CountCars() + " cars in the company.");
        Console.WriteLine("The company has a total car power of " + mainCompany.GetTotalPower());
        return 0;
    }
}