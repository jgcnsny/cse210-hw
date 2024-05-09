using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Reference r2 = new Reference("Proverbs",3, 5,6);
        string text = "Trust in the Lord with all your heart and lean not on. your own understanding; in all your ways submit to. Him, and He will make your paths straight.";
        Scripture s1 = new Scripture(r2,text);
        
        Console.Clear();

        Console.WriteLine(s1.GetDisplayText());

        while(!s1.IsCompletelyHidden())
        {
            Console.WriteLine("Please enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine().ToLower();

            if(input == "quit")
            {
                break;
            }

            s1.HiddenRandomWords(3);

            Console.Clear();

            Console.WriteLine(s1.GetDisplayText());
    
        }
    }
}