using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ActivityPortal
{
    public class Reflecting: Activity
    {

        public override string PerformActivity()
        {
            List<string> _Question = new List<string>{};
            _Question.Add("Think of a time when you stood up for someone else.");
            _Question.Add("Think of a time when you did something really difficult.");
            _Question.Add("Think of a time when you helped someone in need.");
            _Question.Add("Think of a time when you did something truly selfless.");
        

        List<string> _Reflect1 = new List<string>();
            _Reflect1.Add("Why was this experience meaningful to you?");
            _Reflect1.Add("Have you ever done anything like this before?");
            _Reflect1.Add("How did you get started?");
            _Reflect1.Add("How did you feel when it was complete?");
            _Reflect1.Add("What made this time different than other times when you were not as successful?");
            _Reflect1.Add("What is your favorite thing about this experience?");
            _Reflect1.Add("What could you learn from this experience that applies to other situations?");
            _Reflect1.Add("What did you learn about yourself through this experience?");
            _Reflect1.Add("What did you learn about yourself through this experience?");

            DateTime _currentTime = DateTime.Now;
            DateTime _futureTime = _currentTime.AddSeconds(this._activtyDuration);

            Console.Clear();
            Console.WriteLine("Get Ready....");
            this.DisplayAnimation();


            
            

            Console.WriteLine("Consider the following prompt:");
            Console.WriteLine("");
            Random _rand = new Random();
            int _index = _rand.Next(_Question.Count);
            string _randomItem = _Question[_index];
            Console.WriteLine("-----" + _randomItem + "-----");
            Console.WriteLine("");
            Console.WriteLine("When you have something in mind, press enter to contiune.");
            Console.ReadLine();
            Console.WriteLine("You may Begin in:");
            this.DisplayCountdown();
            int i = 0;

            while(DateTime.Now < _futureTime)
            {
                Console.Write("> " + _Reflect1[i++] + " ");
                this.DisplayAnimation();
                Console.Write("\b \b");

            }

        Console.WriteLine("");
        Console.WriteLine("Well Done!!!");
        Console.WriteLine("");

            

        return string.Empty;
        }
        
    }
        


}