using System;

public class BreathingActivity : Activity
{

    public BreathingActivity()
    {
        _name = "Breating Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(3);

        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);

        do
        {
            Console.Write($"\nBreathe In...");
            ShowCountDown(5);
            Console.WriteLine("");

            Console.Write("Now breathe Out...");
            ShowCountDown(6);
            Console.WriteLine("\n");
        }
        while(DateTime.Now < stopTime);

        

        DisplayEndingMessage();
    }
}
