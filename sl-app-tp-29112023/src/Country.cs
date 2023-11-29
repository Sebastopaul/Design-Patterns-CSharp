namespace sl_app_tp_29112023;

public class Country: BookComponent
{
    private readonly IList<Language> _languages = new List<Language>();
    
    public Country(string name): base(name)
    {
        //Database.Instance().AddObject("INSERT INTO country(name) VALUES(" + name + ")");
    }
    
    public void AddLanguage(Language language)
    {
        //var db = Database.Instance();
        //var countryId = int.Parse(db.FindObjectId("SELECT id FROM country WHERE name = " + GetName()));
        //var languageId = int.Parse(db.FindObjectId("SELECT id FROM language WHERE name = " + language.GetName()));
        //
        //db.AddObject("INSERT INTO country_language(country_id, language_id) VALUES(" + countryId + ", " + languageId + ")");
        language.AddCountry(this);
        _languages.Add(language);
    }
    
    public bool IsLanguageUsed(Language language)
    {
        return _languages.Any(savedLanguage => savedLanguage.GetName() == language.GetName());
    }
}