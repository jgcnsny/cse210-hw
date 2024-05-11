using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Reference scriptureReference = new Reference("3 Nephi",5, 13);
        
        Scripture scriptureWords = new Scripture(scriptureReference, "Behold, I am a disciple of Jesus Christ, the Son of God. I have been acalled of him to declare his word among his people, that they might have everlasting life.");
        
        Console.Clear();

        Console.WriteLine(scriptureWords.GetDisplayText());

        while(!scriptureWords.IsCompletelyHidden())
        {
            Console.WriteLine("Please enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine().ToLower();

            if(input == "quit")
            {
                break;
            }

            scriptureWords.HiddenRandomWords(2);

            Console.Clear();

            Console.WriteLine(scriptureWords.GetDisplayText());
    
        }
    }

    
}