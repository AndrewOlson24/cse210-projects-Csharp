using System;

class Program
{
    static void Main(string[] args)
    {
    
        Comments comments = new Comments();
        Video video1 = new Video();
        video1._title = "Harry Potter puppets pals: The Mysterioius Ticking Noise";
        video1._author = "PotterPuppetPals";
        video1._lenght = "2:07";
        video1._viewsInMillions = 203;
        Console.WriteLine("");

        Video video2 = new Video();
        video2._title = "Smooth Criminal (from GLEE) [Cover by Anna ft @CalebHyles]";
        video2._author = "annapantsu";
        video2._lenght = "2:32";
        video2._viewsInMillions = 5;

        Video video3 = new Video();
        video3._title = "Don't Mine At Night - A MINECRAFT parody of Katy Perry's Last Friday Night";
        video3._author = "BebopVox YOGSCAST";
        video3._lenght = "3:49";
        video3._viewsInMillions = 163;

        Video video4 = new Video();
        video4._title = "Set It Off - Why Worry (Official Video)";
        video4._author = "Set It Off";
        video4._lenght = "3:38";
        video4._viewsInMillions = 24;

        Video video5 = new Video();
        video5._title = "The Napolenoic Wars - OverSimplified (part 1)";
        video5._author = "OverSimplified";
        video5._lenght = "29:42";
        video5._viewsInMillions = 43;

        TheDisplay theDisplay = new TheDisplay();
        theDisplay._videos.Add(video1);
        theDisplay._videos.Add(video2);
        theDisplay._videos.Add(video3);
        theDisplay._videos.Add(video4);
        theDisplay._videos.Add(video5);

        theDisplay.Display();
        //comments.Display();




        //Console.WriteLine(comments.theCommentsGeneator());
    

    }
}