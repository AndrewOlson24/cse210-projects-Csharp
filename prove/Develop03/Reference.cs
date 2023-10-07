using System;
using System.Runtime.CompilerServices;


public class Reference
{
    private string _book;
    private int _chapter;
    private string _verse;
    private int _endVerse;



    public Reference(string book, int chapter, string verse)
    {
        
        _book = "Second Nephi";
        _chapter = 9;
        _verse = "28-29";


    }
    public Reference(string _book, int _chapter, int _startVerse, int _endVerse )
    {
        _book = "Second Nephi";
        _chapter = 9;
        _startVerse = 28;
        _endVerse = 29;
    }

    public string GetDisplaytext()
    {
        string text = $"{_book} {_chapter}: {_verse}";
        return text;

    }


}