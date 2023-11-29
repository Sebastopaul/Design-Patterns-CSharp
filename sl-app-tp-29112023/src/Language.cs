namespace sl_app_tp_29112023;

public class Language: BookComponent
{
    private readonly IList<Country> _countries = new List<Country>();
    
    public Language(string name): base(name)
    {
        //Database.Instance().AddObject("INSERT INTO language(name) VALUES(" + name + ")");
    }

    public void AddCountry(Country country)
    {
        _countries.Add(country);
    }

    public bool IsUsedInCountry(Country country)
    {
        return _countries.Any(savedCountry => savedCountry.GetName() == country.GetName());
    }
}