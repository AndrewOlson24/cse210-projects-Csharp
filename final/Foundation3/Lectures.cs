using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading;

namespace ActivityPortal
{
    public class Lecture: Event
    {
    private List<string> _speaker = new List<string>();
    private int _compacity;
        public override string PreformEvent()
        {
            

            return string.Empty;

        }
        public void MaxCompacity()
    {
        _compacity = 70;
        Console.Write("How many Guest will be attending? ");
        string _userInput = Console.ReadLine();
        
        try
        {
            int number = int.Parse(_userInput);
            Console.WriteLine("You entered: " + number);
            if (number <= _compacity)
            {
                int solve =_compacity - number;
                Console.WriteLine("you have " + solve + " people left to fill the room");

            }
            else if ( number == _compacity)
            {
                Console.WriteLine("You hit the limit of Guest you can invite");
            }
            else
            {
                int solve = number - _compacity;
                Console.WriteLine("you have " + solve + " people to many, please uninvite poeple. The MAX for this event is 70.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }


    }
    public Lecture()
    {
        _speaker.Add("Kevin");
        _speaker.Add("Troy");
        _speaker.Add("Tim");
        _speaker.Add("Brave Heart");
        _speaker.Add("Lorenzo VonMatterHorn");
    }
    public void Speaker()
    {
        Random random = new Random();
        int randomindex = random.Next(_speaker.Count);
        string _theSpeaker = _speaker[randomindex];

        Console.WriteLine("The speaker today will be " + _theSpeaker + ".");
    }


        


    }



    }

