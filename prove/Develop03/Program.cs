using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {

      
        Reference reference = new Reference("Second Nephi",1,"1");
        Console.WriteLine(reference.GetDisplaytext());

      //  Scripture scripture = new Scripture();
      //  Console.WriteLine(scripture.GetScriptureString());

      List <Word> _theWords = new List<Word>();
        _theWords = scripture._word;

      while(_theWords.Count()> 0)
      {
        Console.WriteLine(scripture.GetScriptureString());
      }
    }
}