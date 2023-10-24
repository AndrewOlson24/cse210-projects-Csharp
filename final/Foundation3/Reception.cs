using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ActivityPortal
{
    public class Reception
    {
        private bool _rsvp = true;
        public void SetRSVP(bool value)
        {
            _rsvp = value;
        }

        public bool GetRSVP()
        {
            return _rsvp;
        }


        public void AskForRSVP()
        {
            Console.Write("Have you RSVP'd for the event? (yes/no): ");
            string _rsvp = Console.ReadLine().Trim().ToLower();

            if (_rsvp == "yes")
            {
                SetRSVP(true); 
            }
            else if (_rsvp == "no")
            {
                Console.Write("Do you want to Register? ");
                string _register = Console.ReadLine();
                if(_register == "yes")
                {
                    Console.WriteLine("thank you for registering");
                }
                else{
                    Console.WriteLine("you need to register for this event before attending");
                }

                SetRSVP(false); 
            }
            else
            {
                Console.WriteLine("Invalid response. Please enter 'yes' or 'no'.");
                AskForRSVP(); 
            }
        }


    }
}
