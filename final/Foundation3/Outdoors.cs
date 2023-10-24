using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ActivityPortal
{
    public class Outdoors: Event
    {
        public override string PreformEvent()
        {

            
            List<string> _weather = new List<string>();
            _weather.Add("80 Degrees and Sunny");
            _weather.Add("65 Degrees and cloudy");
            _weather.Add("52 Degrees with a chance of rain");
            _weather.Add("78 Degrees and humid today");
            _weather.Add("Its rainning cats and dogs");

            Random random = new Random();
            int index = random.Next(_weather.Count);
            string _randomIndex = _weather[index];
            Console.WriteLine(_randomIndex);

            return string.Empty;

        }










    }
}
