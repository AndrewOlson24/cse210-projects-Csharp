using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ActivityPortal
{
    class Program
    {
        MainMenu _mainMenu = new MainMenu();
        static byte _byChoice = 0;
        static bool _bQuit = false;

        static void Main(string[] args)
        {
            ActivityOperations _activityOps = new ActivityOperations();
            int _sessionTime = 0;
            string _nameOfActivity = "";
            while (!_bQuit)
            {
                MainMenu.DisplayMenu();
                _byChoice = Convert.ToByte(Console.ReadLine());

                switch (_byChoice)
                {
                    case 1:
                        Breathing _breathingActivity = new Breathing();
                        

                        _breathingActivity._activtyName = "Breathing Activity";
                        _breathingActivity._activityDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
                        _breathingActivity._activtyDuration = _activityOps.PresentActivity(_breathingActivity);
                        _sessionTime = _breathingActivity._activtyDuration;
                        _nameOfActivity = _breathingActivity._activtyName;

                        _breathingActivity.PerformActivity();

                        Console.Write("");

                        break;
                    case 2:
                        Reflecting _reflectingActivity = new Reflecting();
                        
                        
                        _reflectingActivity._activtyName = "Reflecting Activity";
                        _reflectingActivity._activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                        _reflectingActivity._activtyDuration = _activityOps.PresentActivity(_reflectingActivity);
                        _sessionTime = _reflectingActivity._activtyDuration;
                        _nameOfActivity = _reflectingActivity._activtyName;

                        _reflectingActivity.PerformActivity();
                        
                        Console.Write("");

                        break;
                    case 3:
                        Listing _listingActivity = new Listing();
                        

                        _listingActivity._activtyName = "Listing Activity";
                        _listingActivity._activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                        _listingActivity._activtyDuration = _activityOps.PresentActivity(_listingActivity);
                        _sessionTime = _listingActivity._activtyDuration;
                        _nameOfActivity = _listingActivity._activtyName;

                        _listingActivity.PerformActivity();

                        Console.Write("");

                        break;
                    case 4:
                        _bQuit = true;
                        break;
                    default:
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("*** Invalid selection - please try again. ***");
                        Console.WriteLine("---------------------------------------------\n");
                        break;
                }
            
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("You have completed " + _sessionTime + " seconds of the " + _nameOfActivity + "!" );
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("-------------THANKS-FOR-PLAYING--------------");
                Console.WriteLine("---------------------------------------------");
            }
        }
    }

   




   
    public abstract class Activity
    {
        public string _activtyName;
        public string _activityDescription;
        public int _activtyDuration;

        public abstract string PerformActivity();

        public void DisplayAnimation()
        {
            Console.Write("|");
            Thread.Sleep(1000);
            Console.Write("\b/");   // Replace it with the - character
            Thread.Sleep(1000);
            Console.Write("\b-");
            Thread.Sleep(1000);
            Console.Write("\b\\");   // Erase the + character
            Thread.Sleep(1000);
            Console.Write("\b|");
            Thread.Sleep(1000);
            Console.WriteLine("\b \b");
        }

        public void DisplayCountdown()
        {
            for (int x = 5; x>= 1; x--)
            {
                Console.Write(x.ToString());
                Thread.Sleep(1000);
                Console.Write("\b");

            }

            Console.WriteLine("\b \b");

        }
     }

    // Menu class
    public class MainMenu
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("Menu options:");
            Console.WriteLine("\t1. Start breathing activity");
            Console.WriteLine("\t2. Start reflecting activity");
            Console.WriteLine("\t3. Start listing activity");
            Console.WriteLine("\t4. Quit");
            Console.Write("Select a choice from the menu: ");
        }
    }

    public class ActivityOperations
    {
        public int PresentActivity(Activity _currentActivity)
        {
            Console.WriteLine("Welcome to the "+_currentActivity._activtyName + ".");
            Console.WriteLine();
            Console.WriteLine(_currentActivity._activityDescription);
            Console.WriteLine();
            Console.WriteLine("How long in seconds would you like for your session?");
            int _secondsActivity = Convert.ToInt32(Console.ReadLine());
            return _secondsActivity;
        }
    }
}