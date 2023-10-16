using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

public class Comments
{
    public List<string> comments = new List<string>();
    public List<string> name = new List<string>();
    public string _theTopComments;
    public string _topComments;
    public string _topComments2;


    public Comments()
    {
        comments.Add("This video sucks!!!");
        comments.Add("That is my favorite video to exlplain this topic for me!! Thank you for the video");
        comments.Add("first");
        comments.Add("This video is soooo fake, its from a video game from 3 years ago, don't believe everythig you see on youtube!!!!");
        comments.Add("this song is the worst!!");
        comments.Add("Did someone say my name?");
        comments.Add("You wanna be a God?" + "- Yes");
        comments.Add("Vote or die this November!!!!!");
        comments.Add("whos here in 2019?");




        name.Add("Jack Orlando");
        name.Add("David Steller");
        name.Add("Steve Martin");
        name.Add("Professor Snape");
        name.Add("Loki, brother of Thor");
        name.Add("Tarzan");
        name.Add("Erik");
        name.Add("Andy Olson");
        name.Add("Obama");
        name.Add("Trump");
        name.Add("Hillary Clinton");

    }

    public string theCommentsGeneator()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, comments.Count);
        int randomIndex2 = random.Next(0, name.Count);
        

        _topComments =  name[randomIndex2];
        _topComments2 = comments[randomIndex];

        _theTopComments = $"{_topComments} \n{_topComments2}";
        
        return _theTopComments;
    }
    public void Display()
    {
       Console.WriteLine(theCommentsGeneator());
    }
}