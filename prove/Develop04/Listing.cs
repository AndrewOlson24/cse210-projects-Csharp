using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ActivityPortal
{

    public class Listing : Activity
    {

        public override string PerformActivity()
        {
            
        
            List<string> _ponder1 = new List<string>();
            _ponder1.Add("Who are people that you appreciate?");
            _ponder1.Add("What are personal strengths of yours?");
            _ponder1.Add("Who are people that you have helped this week?");
            _ponder1.Add("When have you felt the Holy Ghost this month?");
            _ponder1.Add("Who are some of your personal heroes?");
                
            DateTime _currentTime = DateTime.Now;
            DateTime _futureTime = _currentTime.AddSeconds(this._activtyDuration);


            Console.Clear();
            Console.WriteLine("Get Ready.......");
            this.DisplayAnimation();
            Console.WriteLine("List as many responses to the following prompt: ");
            Random _rand = new Random();
            int index = _rand.Next(_ponder1.Count);
            string _randomItem = _ponder1[index];
            Console.WriteLine("-----" + _randomItem + "-----");
            Console.WriteLine("");
            Console.WriteLine("You may begin in...");
            this.DisplayCountdown();

            int _counter = 0;
                while (DateTime.Now < _futureTime)
                {
                    
                    Console.Write("> ");
                    string _name = Console.ReadLine();
                    _counter++;
                }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("you Listed " + _counter + " items!!");
            Console.WriteLine("WELL DONE!!!");

                return string.Empty;

            
        }
    }
}