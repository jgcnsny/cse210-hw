using System;

public class ReflectingActivity: Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description ="This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        

        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);

        DisplayPrompt();
        do
        {
            DisplayQuestions();
        }
        while(DateTime.Now < stopTime);
       
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        Random random = new Random();

        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
        
        Random random = new Random();

        int index = random.Next(_questions.Count);

        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"Consider the following prompt:\n");
        Console.WriteLine($"--- {GetRandomPrompt()}---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadKey();
        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
        Console.Write($"You may begin in: ");
        ShowCountDown(5);
        Console.Clear();
    }

    public void DisplayQuestions()
    {
        
        Console.Write($"> {GetRandomQuestion()} ");
        ShowSpinner(5); 
        Console.WriteLine("\n");
    }
    


}