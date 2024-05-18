using System;
using System.Net.Http.Headers;

public class ListingActivity: Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity()
    {
         _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void Run()
    {
         DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(3);

        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);

        Console.WriteLine($"List as many responses you can to the following prompt:\n");
        Console.WriteLine($"--- {GetRandomPrompt()}---\n");
        Console.Write($"You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        do
        {
            _count += GetListFromUser().Count;
        }
        while(DateTime.Now < stopTime);

        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

        Random random = new Random();

        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        List<string> userEntries = new List<string>();
        Console.Write($"> ");
        string userEntry = Console.ReadLine();
        userEntries.Add(userEntry);

        return userEntries;


    }
}

