using System;
using System.IO;
using System.ComponentModel;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;



PromptGenerator promptGenerator = new PromptGenerator();
Journal journal = new Journal();


bool loopTheJournal = true;

while (loopTheJournal)
{
    // Write Menu
    Console.WriteLine("=========================");
    Console.WriteLine("welcome to the Journal:");
    Console.WriteLine("Please choose your option");
    Console.WriteLine("1. Add new Entry");
    Console.WriteLine("2. Display Journal");
    Console.WriteLine("3. Load Journal file");
    Console.WriteLine("4. Save");
    Console.WriteLine("5. Quit");
    Console.WriteLine("=========================");
    Console.Write("Please choose a number? ");
    string input = Console.ReadLine();

    

    // Perform option they select
    switch (input)
    {
        case "1":
            string prompt = promptGenerator.thePromptGenerator();
            Console.WriteLine(prompt);
            Console.Write("--> ");
            string response = Console.ReadLine();
            DateTime currentDateTime = DateTime.Now;
            string formattedDate = currentDateTime.ToString("yyyy-MM-dd HH:mm:ss");
            File.AppendAllText(journal.JournalFile, $"\n{formattedDate}---  Entry:\n> {prompt} {response}");

            Entry entry = new Entry();
            entry._promptText = prompt;
            entry._entryText = response;
            entry._dateCreated = formattedDate;
            List<Entry> entries = new List<Entry>();
            entries.Add(entry);
            
            



            Console.WriteLine();
            Console.WriteLine("========================");
            Console.WriteLine();
            
            break;
        case "2":

            journal.DisplayFromFile();

            break;
        case "3":
            Console.Write("Would you like to Load from MyJournal.txt? ");
            string answer = Console.ReadLine();
            if (answer == "yes")
            {
                Console.WriteLine("Great");
            }
            else
            {
                Console.Write("What file would you like to load? ");
            }
            Console.WriteLine("Please wait while we load your file...");
            journal.DisplayFromFile();

            break;
        case "4":
            Console.WriteLine("saved to MyJournal.txt");
            

            


            break;
        case "5":
            Console.WriteLine("Thank you for using the Journal");
            Console.WriteLine("Good-bye");
            loopTheJournal = false;
            break;
        default:
            return;
    }



}
