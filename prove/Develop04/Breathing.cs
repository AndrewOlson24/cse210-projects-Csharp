using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ActivityPortal
{
    public class Breathing : Activity
    {
        public override string PerformActivity()
        {
            DateTime _currentTime = DateTime.Now;
            DateTime _futureTime = _currentTime.AddSeconds(this._activtyDuration);
            Console.Clear();
            Console.WriteLine("Get Ready....");
            this.DisplayCountdown();

            while (DateTime.Now < _futureTime)
            {
                Console.WriteLine("> Breathe in...");

                this.DisplayCountdown();

                Console.WriteLine("> Breathe out...");

                this.DisplayCountdown();
            }
            Console.WriteLine("");
            Console.WriteLine("Well Done!!");
            return string.Empty;
        }
    }
}