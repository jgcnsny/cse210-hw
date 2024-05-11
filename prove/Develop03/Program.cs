//I add a ScriptureList class to select random scripture verse
using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        ScriptureList scriptureList = new ScriptureList();
        scriptureList.Scripture(new Reference("3 Nephi", 5, 13), "Behold, I am a disciple of Jesus Christ, the Son of God. I have been called of him to declare his word among his people, that they might have everlasting life.");
        scriptureList.Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ which strengtheneth me.");
        scriptureList.Scripture(new Reference("Proverbs", 3, 5,6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        scriptureList.Scripture(new Reference("D&C", 64, 33,34), "Wherefore, be not weary in well-doing, for ye are laying the foundation of a great work. And out of small things proceedeth that which is great. Behold, the Lord requireth the heart and a willing mind; and the willing and obedient shall eat the good of the land of Zion in these last days.");
        scriptureList.Scripture(new Reference("1 Nephi", 3, 7), "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        
       
        Scripture randomScripture = scriptureList.GetRandomScripture();
        //Reference scriptureReference = new Reference("3 Nephi",5, 13);
        
        //Scripture scriptureWords = new Scripture(scriptureReference, "Behold, I am a disciple of Jesus Christ, the Son of God. I have been acalled of him to declare his word among his people, that they might have everlasting life.");
        
        Console.Clear();

        Console.WriteLine(randomScripture.GetDisplayText());

        while(!randomScripture.IsCompletelyHidden())
        {
            Console.WriteLine("Please enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine().ToLower();

            if(input == "quit")
            {
                break;
            }

            randomScripture.HiddenRandomWords(2);

            Console.Clear();

            Console.WriteLine(randomScripture.GetDisplayText());
    
        }
    }

    
}

public class ScriptureList
{
    private List<Scripture> _scripturesVerse;
    private Random _random;

    public ScriptureList()
    {
        _scripturesVerse = new List<Scripture>();
        _random = new Random();
    }

    public void Scripture(Reference reference, string text)
    {
        _scripturesVerse.Add(new Scripture(reference, text));
    }

    public Scripture GetRandomScripture()
    {
        int index = _random.Next(0, _scripturesVerse.Count);
        return _scripturesVerse[index];
    }
}