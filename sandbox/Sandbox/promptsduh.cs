using System;
using System.Collections.Generic;

public class PromptManager
{
    private List<string> prompts;
    private Random random;

    public PromptManager()
    {
        prompts = new List<string>();
        random = new Random();
    }

    public void AddPrompt(string prompt)
    {
        prompts.Add(prompt);
    }

    public void DisplayRandomPrompt()
    {
        if (prompts.Count == 0)
        {
            Console.WriteLine("No prompts available.");
            return;
        }

        int randomIndex = random.Next(prompts.Count);
        string randomPrompt = prompts[randomIndex];

        Console.WriteLine(randomPrompt);
    }

    public string GetUserResponse()
    {
        Console.Write("Your response: ");
        return Console.ReadLine();
    }
}
