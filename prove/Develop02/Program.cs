// I add a new entry to upload a photo of the day. Since this is a text based program the user will input the path of the image they want to upload
using System;

class Program
{
    static void Main(string[] args)
    {
       Journal journal = new Journal();

       PromptGenerator promptGenerator = new PromptGenerator();

       Console.WriteLine("Welcome to the Journal Program!");

       bool exit = false;

       while(!exit)
       {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        Console.Write("What would you like to do? ");
        string respond = Console.ReadLine();

        if(respond == "1")
        {
            string randomPrompt = promptGenerator.GetRandomPrompt();
            string currentDate = DateTime.Now.ToString("MM/dd/yyyy");
            Console.WriteLine(randomPrompt);
            Console.Write("> ");
            string userEntry = Console.ReadLine();
            Console.Write("Upload your photo of the day (url path): ");
            string imageEntry = Console.ReadLine();
            Entry newEntry = new Entry();
            newEntry._date = currentDate;
            newEntry._promptText = randomPrompt;
            newEntry._entryText = userEntry;
            newEntry._imagePath = imageEntry;

            journal.AddEntry(newEntry);
        }
        else if(respond == "2")
        {
            journal.DisplayAll();
        }
        else if(respond == "3")
        {
            Console.Write("What is the filename? ");
            string journalLoad = Console.ReadLine();
            journal.LoadFromFile(journalLoad);
        }
        else if(respond == "4")
        {
            Console.Write("What is the filename? ");
            string journalFile = Console.ReadLine();
            journal.SaveToFile(journalFile);
        }
        else if(respond == "5")
        {
            exit = true;
        }
        else
        {
            Console.WriteLine("Invalid option. Please select again");
        }
        
       }
    }
}