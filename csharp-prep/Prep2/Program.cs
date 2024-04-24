using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your Grade Percentage? ");
        string grade = Console.ReadLine();
        int gradePercentage = int.Parse(grade);

        string letterGrade = "";

        if (gradePercentage >= 90)
        {
            letterGrade = "A";
        }
        else if (gradePercentage >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercentage >= 70)
        {
            letterGrade = "C";
        }
        else if (gradePercentage >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        //Stretch Challenge 1
            char sign;

            int last_digit = gradePercentage % 10;

            if (last_digit >= 7)
            {
                sign = '+' ;
            }
                
            else if (last_digit < 3)
            {
                sign = '-' ;
            }
            else
            {
                sign = ' ' ;
            }

        //Stretch Challenge 2
            if (gradePercentage >= 93)
            {
                sign = ' ';
            }

        //Stretch Challenge 3
            if (letterGrade == "F")
            {
                sign = ' ';
            }
                

        Console.WriteLine($"Your Grade is: {letterGrade}{sign}");

        if(gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You Passed!");
        }
        else 
        {
            Console.WriteLine("Stay focused and you'll get it next time!");
        }

    }
}