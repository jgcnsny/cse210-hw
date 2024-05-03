using System;
using System.ComponentModel;

public class PromptGenerator
{
   private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What are you grateful for today?",
        "What is your greatest achievement today?",
        "How are you feeling today?"
        // Add more prompts as needed
    };
   
   public string GetRandomPrompt()
   {
    Random rand = new Random();

    int index = rand.Next(_prompts.Count);

    return _prompts[index];
   }
}