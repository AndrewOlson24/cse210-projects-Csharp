using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;



public class PromptGenerator
{
    public List<string> prompts = new List<string>();
    public PromptGenerator() {

            prompts.Add("Who was the most interesting person I interacted with today?");
            prompts.Add("What was the best part of my day?");
            prompts.Add("How did I see the hand of the Lord in my life today?");
            prompts.Add("What was the strongest emotion I felt today?");
            prompts.Add("If I had one thing I could do over today, what would it be?");
        

    }

   public string thePromptGenerator()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, prompts.Count);

        // Return the randomly selected sentence
        return prompts[randomIndex];
    }

}