using System;
using System.ComponentModel;

public class PromptGenerator
{
   private List<string> _prompts = new List<string>
    {
        "What motivated me today?",
        "What areas of my life I want to improved?",
        "How can I love myself more?",
        "What is one piece of advice I'd give to my future self?",
        "If I had one thing I could do over today, what would it be?",
        "What I am grateful for?",
        "What is your greatest achievement today?",
        "How I am feeling today?"
        // Add more prompts as needed
    };
   
   public string GetRandomPrompt()
   {
    Random random = new Random();

    int index = random.Next(_prompts.Count);

    return _prompts[index];
   }
}