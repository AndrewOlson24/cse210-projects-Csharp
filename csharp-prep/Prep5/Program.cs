using System;

class Program
{

    static void Main(string[] args)
    {

        DisplayMessage();

        string playerName = PromptUserName();
        int playerNumber = PromptUserNumber();
        int theSquare = SquareNumber(playerNumber);

        DisplayResult(playerName, theSquare);






        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("what is your name? ");
            string name = Console.ReadLine();

            return name;
            
        }

        static int PromptUserNumber(){

            Console.Write("What is your favorite number? ");
            int first = int.Parse(Console.ReadLine());

            return first;

        }
        static int SquareNumber(int number)
        {
            int square = number*number;

            return square;
        }

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        } 
    }

    
    
}