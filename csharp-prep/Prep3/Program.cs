using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        

        int guess_count = 0;

        string play_again = "yes";

        while(play_again == "yes")
        {
            int magic_number = randomGenerator.Next(1, 100);
            Console.Write("What is your guess? ");
            int guess_number = int.Parse(Console.ReadLine());

             guess_count = guess_count + 1;

             while(guess_number != magic_number)
             {
                if(guess_number > magic_number)
                {
                    Console.WriteLine("Lower");
                    Console.Write("What is your guess? ");
                    guess_number = int.Parse(Console.ReadLine());
                    guess_count = guess_count + 1;
                }
                else if (guess_number < magic_number)
                {
                    Console.WriteLine("Higher");
                    Console.Write("What is your guess? ");
                    guess_number = int.Parse(Console.ReadLine());
                    guess_count = guess_count + 1;
                }
                else
                {
                    guess_count = guess_count + 1;
                    Console.WriteLine("You guessed it!");
                }

             }

                Console.WriteLine($"It took you {guess_count} guesses");

                Console.Write("Do you want to play again? yes or no: ");
                play_again = Console.ReadLine();

        }

        Console.WriteLine("Thank you for playing!");
    }
}