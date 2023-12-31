﻿namespace sl_app_tp_29112023;

public class NovelWriter: Writer
{
    public NovelWriter(string name, Country country) : base(name, country)
    {
    }

    public override Book WriteBook(string name, string content, Genre genre, Language language)
    {
        if (! HasWrittenGenre(genre))
            AddGenre(genre);
        if (! GetCountry().IsLanguageUsed(language))
            throw new KeyNotFoundException("This language is spoken in this country.");
        var book = new BookNovel(name, content, this, language, genre);
        Books.Add(book);
        NotifySubscribers(book);
        return book;
    }
}