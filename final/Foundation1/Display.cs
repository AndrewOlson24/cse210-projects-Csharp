using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

public class TheDisplay
{
    public List<Video> _videos = new List<Video>();
    public  Comments _comments = new Comments();

    public void Display()
    {
        
        foreach (Video video in _videos)
        {
            video.Display();
            Console.WriteLine("=================================================================");
            Console.WriteLine("Top Comments");
            Console.WriteLine("");
            _comments.Display();
            Console.WriteLine("");
            _comments.Display();
            Console.WriteLine("");
            _comments.Display();
            Console.WriteLine("");
            _comments.Display();
            Console.WriteLine("=================================================================");
            

        }
    }
}