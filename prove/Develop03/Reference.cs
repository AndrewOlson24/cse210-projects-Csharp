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
        
        _book = "John";
        _chapter = 8;
        _verse = "56-58";


    }
    public Reference(string book, int chapter, int startVerse, int endVerse )
    {
        _book = "John";
        _chapter = 8;
        //_startVerse = 56;
        _endVerse = 58;
    }

    public string GetDisplaytext()
    {
        string text = $"{_book} {_chapter}: {_verse}";
        return text;

    }


}