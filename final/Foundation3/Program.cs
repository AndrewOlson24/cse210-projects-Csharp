using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ActivityPortal
{
    class Program
    {
        MainMenu mainMenu = new MainMenu();
        
        static bool _bQuit = false;
        static byte _byChoice = 0;
        static void Main(string[] args)
        {


            while (!_bQuit)
            {
                MainMenu.DisplayMenu();
                _byChoice = Convert.ToByte(Console.ReadLine());

                switch (_byChoice)
                {
                    case 1:
                       // Lecture lecture = new Lecture();
                       // lecture.PreformEvent();
                        break;

                    case 2:
                        break;
                
                    case 3:
                    Outdoors outdoors = new Outdoors();
                    Address address = new Address("23222 130th ave S.E.", "Kent", "Kentucky", "99989");
                    outdoors._event_title = "How to Hike Mt Everest";
                    outdoors._description = "Learn How to acheive your dreams and hike the greatest challenge ever";
                    outdoors._date = "December 3rd";
                    outdoors._time = "12:30pm";
                    string fullsentence = $"{outdoors._event_title}\n{outdoors._description}\n{outdoors._time}-{outdoors._date}";
                    Console.WriteLine(fullsentence);
                    address.GetAddress();

                    outdoors.PreformEvent();
                    

                        break;
                }
            }
            

            
            
            
            
            
            
            
            
            
            
            
            
            Reception reception = new Reception();
            reception.AskForRSVP();
            bool hasRSVP = reception.GetRSVP();
            if (hasRSVP)
            {
                Console.WriteLine("The person has RSVP'd for the event.");
            }
            else
            {
                Console.WriteLine("The person has not RSVP'd for the event.");
            }
            // Outdoors outdoors = new Outdoors();
            // outdoors.PreformBasic();
            //  Lecture lecture = new Lecture();
            // lecture.MaxCompacity();
            // lecture.Speaker();
        }
    }














    public abstract class Event
    {

        public string _event_title;
        public string _description;
        public string _date;
        public string _time; 

        
        public abstract string PreformEvent();

    }
    public class Address
    {
        private string _address;
        private string _city;
        private string _state;
        private string _zipcode;


        public Address(string _address, string _city, string _state, string _zipcode)
        {
            _address = "26333 130th ave S.E. ";
            _city = "Kent ";
            _state = "Washington";
            _zipcode = "98042";
        }

        public string GetAddress()
        {
           string cheese = $"{_address} {_city} {_state} {_zipcode}";
           return cheese;
        }

    }
    
    public class MainMenu
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("Welcome to the Event Planner, What would you like to do? ");
            Console.WriteLine("\t1. Plan a Lecture");
            Console.WriteLine("\t2. PLan a Reception");
            Console.WriteLine("\t3. Plan an Outdoor activity");
            Console.WriteLine("\t4. Quit");
            Console.Write("Please select a choice from the menu: "); 
        }
    }
}



