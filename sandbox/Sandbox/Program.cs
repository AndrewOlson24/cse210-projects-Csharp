using System;

class Program
{
    static void Main(string[] args)
    {
        PromptManager promptManager = new PromptManager();

        // Add prompts
        promptManager.AddPrompt("What is your favorite color?");
        promptManager.AddPrompt("Tell me about your last vacation.");
        promptManager.AddPrompt("What are your career goals?");

        while (true)
        {
            Console.Clear(); // Clear the console for a clean display.
            promptManager.DisplayRandomPrompt();
            string userResponse = promptManager.GetUserResponse();
            Console.WriteLine($"You typed: {userResponse}");

            // You can add more logic here, such as saving responses or continuing the loop.
        }
    }
}