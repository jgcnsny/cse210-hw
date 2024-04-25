using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        List<int> num_lists = new List<int>();

        int num_input = -1;
        int largest_num = 0;
        int num_sum = 0;
        
        
        int smallest_positive = 100;

        Console.WriteLine("Enter a list of numbers type 0 when finished.");

        while (num_input !=0)
        {
            Console.Write("Enter a number: ");
            string user_input = Console.ReadLine();
            num_input = int.Parse(user_input);

            if(num_input != 0)
            {
                num_lists.Add(num_input);

            }
        }

        foreach(int number in num_lists)
        {
            num_sum += number;

            if (number > largest_num)
            {
                largest_num = number;
            }

            if(number > 0 && number < smallest_positive){
                smallest_positive = number;
            }

        }

        float num_ave = ((float)num_sum )/ num_lists.Count;

        Console.WriteLine($"The sum is: {num_sum}");
        Console.WriteLine($"The average is: {num_ave}");
        Console.WriteLine($"The largest number is: {largest_num}");
        Console.WriteLine($"The smallest positive number is: {smallest_positive}");

        num_lists.Sort();
        Console.WriteLine($"The sorted list is: ");
        foreach(int number in  num_lists)
        {
            Console.WriteLine(number);
        }

    }
}