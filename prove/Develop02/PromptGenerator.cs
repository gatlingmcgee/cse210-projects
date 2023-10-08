using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Console.WriteLine("What was the best part of your day?");
// Console.WriteLine("What was the worst part of your day?");
// Console.WriteLine("What can you do better tomorrow?");
// Console.WriteLine("What is something you would like to change?");

public class PromptGenerator
{
    public List<string> _prompts = new List<string>() {"How can you get to know your Heavenly Father better?", 
    "What was the best part of your day?", 
    "What can you do better tomorrow?", 
    "Who can I help or visit tomorrow", 
    "What was the worst part of your day?", 
    "What is something you would like to change?"};
    
    Random opt = new Random();

    public string GetPrompt()
    {
        Console.WriteLine();
        int index = opt.Next(_prompts.Count());
        return _prompts[index];
    }
}