using System;
using System.Security.Cryptography.X509Certificates;


public class Word
{

    private string _text;
    private bool _isHidden = false;

    public Word(string theScripture)
    {
       _text = theScripture;

        
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }
    public void IsHidden()
    {
        _isHidden = true;

    }
    public bool GetHidden()
    {
        return _isHidden;
    }

    public string GetWord()
    {
        return _text;
    }


}