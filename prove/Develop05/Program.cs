using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EternalQuest
{
    class Program
    {
        static List<Goal> Goals = new List<Goal>();
        static int iTotalPoints = 0;
        static int iChoice = -1;
        static bool exitApp = false;

        static void Main(string[] args)
        {
            menuSystem mSys = new menuSystem();
            goalOperations gOps = new goalOperations();

    

            while (exitApp == false)
            {
                Console.WriteLine("Total Points Earned >>> " + iTotalPoints.ToString());
                Console.WriteLine();

                // Display the main menu
                mSys.displayMenu(0);
                iChoice = getInt(Console.ReadLine(),1);
                Console.WriteLine();   //Insert a blank line

                if (iChoice == 1)
                {
                    mSys.displayMenu(1);   //Display the goal selection menu
                    iChoice = getInt(Console.ReadLine(), 1);
                    Console.WriteLine();   //Insert a blank line

                    switch (iChoice)
                    {
                        case 1:
                            Simple simpleGoal = new Simple();

                            Console.Write("What is the name of your goal? ");
                            simpleGoal.name = Console.ReadLine();
                            Console.Write("What is a short discription of it? ");
                            simpleGoal.description = Console.ReadLine();
                            Console.Write("How many points do you want to make this? ");
                            simpleGoal.points = getInt(Console.ReadLine(),100);

                            Console.WriteLine();   //Insert a blank line after data entry

                            Goals.Add(simpleGoal);   //Add our new goal to the goals list

                            break;
                        case 2:
                            Eternal eternalGoal = new Eternal();

                            Console.Write("What is the name of your goal? ");
                            eternalGoal.name = Console.ReadLine();
                            Console.Write("What is a short discription of it? ");
                            eternalGoal.description = Console.ReadLine();
                            Console.Write("How many points do you want to make this? ");
                            eternalGoal.points = getInt(Console.ReadLine(),50);

                            Console.WriteLine();   //Insert a blank line after data entry

                            Goals.Add(eternalGoal);   //Add our new goal to the goals list

                            break;
                        case 3:
                            Checklist checklistGoal = new Checklist();

                            Console.Write("What is the name of your goal? ");
                            checklistGoal.name = Console.ReadLine();
                            Console.Write("What is a short discription of it? ");
                            checklistGoal.description = Console.ReadLine();
                            Console.Write("How many points do you want to make this? ");
                            checklistGoal.points = getInt(Console.ReadLine(),150);
                            Console.Write("How many times do you need to do this to get the BONUS points? ");
                            checklistGoal.targetEventNum = getInt(Console.ReadLine(),3);
                            Console.Write("How many BONUS points should be received when goal completed? ");
                            checklistGoal.bonusPoints = getInt(Console.ReadLine(),500);

                            Console.WriteLine();   //Insert a blank line after data entry

                            Goals.Add(checklistGoal);   //Add our new goal to the goals list

                            break;

                        default:
                            Console.WriteLine("---------------------------------------------");
                            Console.WriteLine("*** Invalid selection - please try again. ***");
                            Console.WriteLine("---------------------------------------------\n");

                            break;
                    }
                }
                else if (iChoice == 2)   // List
                {
                    if (Goals.Count > 0)
                    { gOps.list(Goals); }
                    else
                    {
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("***    No goals to list - create first.   ***");
                        Console.WriteLine("---------------------------------------------\n");
                    }
                }
                else if (iChoice == 3)   // Save
                {
                    if (Goals.Count > 0)
                    {
                        gOps._totalPoints = iTotalPoints;
                        gOps.save(Goals);
                    }
                    else
                    {
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("***    No goals to save - create first.   ***");
                        Console.WriteLine("---------------------------------------------\n");
                    }
                }
                else if (iChoice == 4)   // Load
                {
                    Console.Write("What goal file should be loaded? ");
                    string myGoals = Console.ReadLine();

                    string fullPath2File = gOps._filePath + myGoals;
                    if (!System.IO.File.Exists(fullPath2File))
                    {
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("***   File does not exist; load failed.   ***");
                        Console.WriteLine("---------------------------------------------\n");
                    }
                    else
                    {
                        Goals = gOps.load(myGoals);   //Override our current list with new list from file
                        iTotalPoints = gOps._totalPoints;   //Retrieve total points accumulated from file
                    }
                }
                else if (iChoice == 5)   // Record
                {
                    if (Goals.Count > 0)
                    {
                        gOps.list(Goals);

                        // Get the goal to record event for...
                        iChoice = getInt(Console.ReadLine(),1);

                        if (iChoice >= 1 && iChoice <= Goals.Count)
                        { iTotalPoints += Goals[--iChoice].recordEvent(); }
                        else
                        {
                            Console.WriteLine("---------------------------------------------");
                            Console.WriteLine("***  Invalid goal choice; record failed.  ***");
                            Console.WriteLine("---------------------------------------------\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("***   No goals to record - create first.  ***");
                        Console.WriteLine("---------------------------------------------\n");
                    }
                }
                else if (iChoice == 6)   // Quit
                { exitApp = true; }
                else
                {
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("*** Invalid selection - please try again. ***");
                    Console.WriteLine("---------------------------------------------\n");
                }
            }
        }

        public static int getInt(string strNum, int defVal)
        {
            int iParsedNum;

            if (!int.TryParse(strNum, out iParsedNum))
            { return defVal; }
            else
            { return iParsedNum; }
        }
    }

    public abstract class Goal
    {
        public string name;
        public string description;
        public int points;

        public abstract string getScreenString();

        public abstract string getFileString();

        public abstract int recordEvent();
    }

    public class Simple : Goal
    {
        public bool done = false;

        public override string getScreenString()
        {
            StringBuilder goalText = new StringBuilder(" ");

            if (!this.done) { goalText.Append("[ ] "); } else { goalText.Append("[x] "); }
            goalText.Append(this.name);
            goalText.Append(" (");
            goalText.Append(this.description);
            goalText.Append(")");

            return goalText.ToString();
        }

        public override string getFileString()
        {
            StringBuilder goalText = new StringBuilder("Simple|");

            goalText.Append(this.name);
            goalText.Append('~');
            goalText.Append(this.description);
            goalText.Append('~');
            goalText.Append(this.points.ToString());
            goalText.Append('~');
            goalText.Append(this.done.ToString());

            return goalText.ToString();
        }
        public override int recordEvent()
        {
            done = true;
            return this.points;
        }
    }

    public class Eternal : Goal
    {
        public override string getScreenString()
        {
            StringBuilder goalText = new StringBuilder(" ");

            goalText.Append("[ ] ");
            goalText.Append(this.name);
            goalText.Append(" (");
            goalText.Append(this.description);
            goalText.Append(")");

            return goalText.ToString();
        }
        public override string getFileString()
        {
            StringBuilder goalText = new StringBuilder("Eternal|");

            goalText.Append(this.name);
            goalText.Append('~');
            goalText.Append(this.description);
            goalText.Append('~');
            goalText.Append(this.points.ToString());

            return goalText.ToString();
        }
        public override int recordEvent()
        {
            return this.points;
        }
    }

    public class Checklist : Goal
    {
        public int bonusPoints;
        public int targetEventNum;
        public int eventsComplete;

        public override string getScreenString()
        {
            StringBuilder goalText = new StringBuilder(" ");

            if (this.targetEventNum == this.eventsComplete) { goalText.Append("[X] "); } else { goalText.Append("[ ] "); }
            
            goalText.Append(this.name);
            goalText.Append(" (");
            goalText.Append(this.description);
            goalText.Append(")----");
            goalText.Append("-- Currently completed: ");
            goalText.Append(this.eventsComplete + "/" + this.targetEventNum);

            return goalText.ToString();
        }

        public override string getFileString()
        {
            StringBuilder goalText = new StringBuilder("Checklist|");

            //[] Andy: complete logic here using examples from Simple and Eternal goals above
            goalText.Append(this.name);
            goalText.Append('~');
            goalText.Append(this.description);
            goalText.Append('~');
            goalText.Append(this.points.ToString());
            goalText.Append("~");
            goalText.Append(this.bonusPoints.ToString());
            goalText.Append("~");
            goalText.Append(this.targetEventNum.ToString());
            goalText.Append("~");
            goalText.Append(this.eventsComplete.ToString());
            return goalText.ToString();
        }

        public override int recordEvent()
        {
            int iPoints2Return = 0;

            this.eventsComplete++;

            if(this.targetEventNum == this.eventsComplete)
            { iPoints2Return = this.points + this.bonusPoints; }
            else{ iPoints2Return = this.points;}

            return iPoints2Return;
        }
    }

    public class goalOperations
    {
        // Hold the totalpoints accumlated when goal operations in play
        public int _totalPoints = 0;
        // This is the location in the file system where our goals data will be stored
        public string _filePath = string.Empty;

        public void save(List<Goal> goalsList)
        {
            if (goalsList.Count > 0)
            {
                Console.Write("Goal(s) storage file name: ");
                string gsfn = Console.ReadLine();

                // If same name as already existing file, StreamWriter will overwrite the existing contents
                using (StreamWriter outputFile = new StreamWriter(this._filePath + gsfn))   //using cleans file resources on exit {}
                {
                    //[x] First line is always our point total
                    outputFile.WriteLine(_totalPoints.ToString());

                    //[x] Write out goals in List order (as added during execution)
                    foreach (Goal g in goalsList)
                    { outputFile.WriteLine(g.getFileString()); }
                }

                Console.WriteLine("Goals successfully saved to: [" + gsfn + "]");   //Notify the user of saved data
            }
            else
            {
                Console.WriteLine("No goals to save.");
            }

            Console.WriteLine();   
        }

        public List<Goal> load( string gsfn)
        {
            List<Goal> goalsList = new List<Goal>();
            string[] records = System.IO.File.ReadAllLines(this._filePath + gsfn);
            char[] sc = { '|', '~' };

            byte bLineNum = 0;
            foreach (string record in records)
            {
				if (++bLineNum == 1)
                {
                    _totalPoints = Convert.ToInt32(record);
                    continue;
                }
            string[] fields = record.Split(sc);

            string goalType = fields[0];

            switch (goalType.ToLower())
            {
                case "simple":
                    Simple sGoal = new Simple();

                    sGoal.name = fields[1];
                    sGoal.description = fields[2];
                    sGoal.points = Convert.ToInt32(fields[3]);
                    sGoal.done = Convert.ToBoolean(fields[4]);

                    goalsList.Add(sGoal);
                    break;

                case "eternal":

                    Eternal eGoal = new Eternal();

                    eGoal.name = fields[1];
                    eGoal.description = fields[2];
                    eGoal.points = Convert.ToInt32(fields[3]);
                   

                    goalsList.Add(eGoal);
                    break;

                case "checklist":

                    Checklist cGoal = new Checklist();

                    cGoal.name = fields[1];
                    cGoal.description = fields[2];
                    cGoal.points = Convert.ToInt32(fields[3]);
                    cGoal.bonusPoints = Convert.ToInt32(fields[4]);
                    cGoal.targetEventNum = Convert.ToInt32(fields[5]);
                    cGoal.eventsComplete = Convert.ToInt32(fields[6]);

                    goalsList.Add(cGoal);
                    break;

            }
            
            }
            

            return goalsList;
        }

        public void list(List<Goal> goalsList)
        {
            Console.WriteLine("The goals are:");
            Console.WriteLine("-------------");

            int dispx = 1;
            foreach (Goal g in goalsList)
            {
                Console.WriteLine(dispx.ToString() + "." + g.getScreenString());
                dispx++;
            }

            Console.WriteLine();   //Add blank line seperator after list
        }
    }

    public class menuSystem
    {
        public void displayMenu(int iMenu)
        {
            switch( iMenu )
            {
                case 0:
                {
                    Console.WriteLine("Eternal Quest Menu options:");
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("\t1. Create New Goal");
                    Console.WriteLine("\t2. List Goals");
                    Console.WriteLine("\t3. Save Goals");
                    Console.WriteLine("\t4. Load Goals");
                    Console.WriteLine("\t5. Record Events");
                    Console.WriteLine("\t6. Quit" + "\n");
                    Console.Write("Please choose your option: ");
                    break;
                }
                case 1:
                {
                    Console.WriteLine("The type of goals are:");
                    Console.WriteLine("---------------------");
                    Console.WriteLine("\t1. Simple Goal");
                    Console.WriteLine("\t2. Eternal Goal");
                    Console.WriteLine("\t3. CheckList Goal" + "\n");
                    Console.Write("What type of goal would you like to create: ");
                    break;
                }
            }
        }
    }
}