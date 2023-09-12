using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int newNumber = -1;
        while (newNumber != 0)
        {
            
            Console.Write("Enter Number: ");
            string enterNumber = Console.ReadLine();
            newNumber = int.Parse(enterNumber);

            if (newNumber != 0)
            {
                numbers.Add(newNumber);
            }

            
        }
        int theCount = numbers.Count;
        int theSum = numbers.AsQueryable().Sum();
        int theAverage = theSum / theCount;
        int largeNumber = numbers.Max();
        Console.WriteLine("The Sum is: " + theSum);
        Console.WriteLine("The Average is: " + theAverage);
        Console.WriteLine("The Largest number is: " + largeNumber);




    }
}