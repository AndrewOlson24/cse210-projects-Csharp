using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

public class Video
{
    public string _title;
    public string _author;
    public string _lenght;
    public int _viewsInMillions;

    public void Display()
    {
        Console.WriteLine($"{_title}\n{_author}\n{_lenght}\n{_viewsInMillions}\n");
    
        
    }
  
}