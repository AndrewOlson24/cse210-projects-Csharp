using System;
using System.ComponentModel;
using System.IO;
using System.Collections.Generic;


public class Scripture
{

    public List<Word> _words = new List<Word>();
    public int x;

    public Reference _reference;

    public Scripture()
    {
        
    }

    public void buildScripture(){
        Word word1 = new Word("Your");
        Word word2 = new Word ("father");
        Word word3 = new Word ("Abraham");
        Word word4 = new Word ("rejoiced");
        Word word5 = new Word ("t0");
        Word word6 = new Word ("see");
        Word word7 = new Word ("my");
        Word word8 = new Word ("day");
        Word word9 = new Word ("and");
        Word word10 = new Word ("he");
        Word word11 = new Word ("saw");
        Word word12 = new Word ("it");
        Word word13 = new Word ("and");
        Word word14 = new Word ("was");
        Word word15 = new Word ("glad");
        Word word16 = new Word ("then");
        Word word17 = new Word ("said");
        Word word18 = new Word ("the");
        Word word19 = new Word ("Jews");
        Word word20 = new Word ("unto");
        Word word21= new Word ("him");
        Word word22 = new Word ("thou");
        Word word23 = new Word ("art");
        Word word24 = new Word ("not");
        Word word25 = new Word ("yet");
        Word word26 = new Word ("fifty");
        Word word27 = new Word ("years");
        Word word28 = new Word ("old");
        Word word29 = new Word ("and");
        Word word30 = new Word ("hast");
        Word word31 = new Word ("thou");
        Word word32 = new Word ("seen");
        Word word33 = new Word ("Abraham");
        Word word34 = new Word ("Jesus");
        Word word35 = new Word ("said");
        Word word36 = new Word ("unto");
        Word word37 = new Word ("them");
        Word word38 = new Word ("Verily");
        Word word39 = new Word ("verily");
        Word word40 = new Word ("I");
        Word word41 = new Word ("say");
        Word word42 = new Word ("unto");
        Word word43 = new Word ("you");
        Word word44 = new Word ("Before");
        Word word45 = new Word ("Abraham");
        Word word46 = new Word ("was");
        Word word47 = new Word ("I");
        Word word48 = new Word ("AM");

        _words.Add(word1);
        _words.Add(word2); 
        _words.Add(word3); 
        _words.Add(word4); 
        _words.Add(word5); 
        _words.Add(word6); 
        _words.Add(word7); 
        _words.Add(word8); 
        _words.Add(word9); 
        _words.Add(word10); 
        _words.Add(word11); 
        _words.Add(word12);
        _words.Add(word13); 
        _words.Add(word14); 
        _words.Add(word15); 
        _words.Add(word16); 
        _words.Add(word17); 
        _words.Add(word18); 
        _words.Add(word19); 
        _words.Add(word20); 
        _words.Add(word21); 
        _words.Add(word22); 
        _words.Add(word23); 
        _words.Add(word24); 
        _words.Add(word25); 
        _words.Add(word26); 
        _words.Add(word27); 
        _words.Add(word28); 
        _words.Add(word29); 
        _words.Add(word30); 
        _words.Add(word31); 
        _words.Add(word32); 
        _words.Add(word33); 
        _words.Add(word34); 
        _words.Add(word35); 
        _words.Add(word36); 
        _words.Add(word37); 
        _words.Add(word38); 
        _words.Add(word39); 
        _words.Add(word40); 
        _words.Add(word41); 
        _words.Add(word42); 
        _words.Add(word43); 
        _words.Add(word44); 
        _words.Add(word45); 
        _words.Add(word46); 
        _words.Add(word47); 
        _words.Add(word48); 
        
        
        
    }

    

       public List<string> GetScriptureVerse()
      {
        
         return _words

      }

    public string GetScriptureString()
    {
        string scripture = "";
        foreach (Word word in _words)
        {
            if (!word.GetHidden())
            scripture += word.GetWord()+" ";

        }
        return scripture;
    }
    public string HideWords()
    {
       Random random = new Random();
        for( int i = 0; i < 3; i++)
        {
           while();
       }
    }
}