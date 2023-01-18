using System;
using System.Collections.Generic;

public class PromptGenerator
  
{
    public List<string> prompts = new List<string>
    {
        "What do you want to improve?",
        "How was your day?",
        "Did you do everything you had to?",
        "Any plans for the weekend?",
        "Who would you like to visit this week?"
    };

    public void DisplayRandom()
    {
        Random random = new Random();
        int randomPrompt = random.Next(prompts.Count);
        Console.WriteLine(prompts[randomPrompt]);
        string prompt = prompts[randomPrompt];
        
    }
        
}
    




