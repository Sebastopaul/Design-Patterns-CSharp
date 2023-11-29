namespace sl_app_tp_29112023;

public class Country: BookComponent
{
    private readonly IList<Language> _languages = new List<Language>();
    
    protected Country(string name): base(name)
    {
        Database.Instance().AddObject("INSERT INTO country(name) VALUES(" + name + ")");
    }
    
    public void AddCountry(Language language)
    {
        var db = Database.Instance();
        var countryId = int.Parse(db.FindObjectId("SELECT id FROM country WHERE name = " + this.GetName()));
        var languageId = int.Parse(db.FindObjectId("SELECT id FROM language WHERE name = " + language.GetName()));
        
        db.AddObject("INSERT INTO country_language(country_id, language_id) VALUES(" + countryId + ", " + languageId + ")");
        _languages.Add(language);
    }
    
    public bool IsUsedInCountry(Language language)
    {
        return _languages.Any(savedLanguage => savedLanguage.GetName() == language.GetName());
    }
}