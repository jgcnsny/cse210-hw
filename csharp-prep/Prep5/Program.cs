using System;

class Program
{
    static void Main(string[] args)
    {
        
        DisplayWelcome();
        string username = PropmptUserName();
        int usernumber = PromptUserNumber();

        int square_num = SquareNumber(usernumber);

        DisplayResult(username, square_num);


    }

    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the pogram!");
        }

        static string PropmptUserName()
        {
            Console.Write("Please enter your name: ");
            string user_name = Console.ReadLine();

            return user_name;

        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your name: ");
        
            int user_number= int.Parse(Console.ReadLine());

            return user_number;
        }

        static int SquareNumber(int number)
        {
            int squared = number * number;
            return squared;
        }

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
}