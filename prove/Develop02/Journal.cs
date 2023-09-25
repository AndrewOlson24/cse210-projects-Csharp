using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Journal
    {

        public string JournalFile = "MyJournal.txt";

        public List<Entry>  _entries;



        public void AddEntry(Entry newEntry)
        {

        }
        public void DisplayAll()
        {
            Console.WriteLine(JournalFile);
        }
        public void CreateJournalFiles()
        {
            if(!File.Exists(JournalFile))
            {
                File.CreateText(JournalFile);
            }
        }
        public static void SaveToFIle(List<Entry> Entry)
        {
            string filename = "MyJournal.txt";

            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (Entry e in Entry)
                {
                    outputFile.WriteLine(e._promptText);
                    outputFile.WriteLine(e._entryText);
                    outputFile.WriteLine(e._dateCreated);

                }
               
            }
            
        }
        public void DisplayFromFile()
        {
            string journalText = File.ReadAllText(JournalFile);
            Console.WriteLine("\n=== Journal Content === ");
            Console.WriteLine(journalText);
            Console.WriteLine("\n======================= ");
        }

}