//I add a SaveToFile and LoadFromFile method in the ListingActivity to save and load the list of responses entered by the user and I also add a if else statment to ask the user
//if they want to save the file. In the menu I add a new option #5 Load Listing Activity File to Load and Display the response
using System;

class Program
{
    static void Main(string[] args)
    {
        var choice = "";

        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start Breathing activity");
            Console.WriteLine(" 2. Start Reflecting activity");
            Console.WriteLine(" 3. Start Listing Activity");
            Console.WriteLine(" 4. Quit");
            Console.WriteLine(" 5. Load Listing Activity File");
            
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
            else if(choice == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }
            else if (choice == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Goodbye!");
            }
            else if (choice == "5")
            {
                Console.WriteLine("\n");
                ListingActivity listingActivity =  new ListingActivity();
                Console.Write("What is the filename? ");
                string listFile = Console.ReadLine();
                listingActivity.LoadFromFile(listFile);
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("Invalid Choice. Try Again!");
            }
        }
        while (choice!="4");
        Console.Clear();
    }
}