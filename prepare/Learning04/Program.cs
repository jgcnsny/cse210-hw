using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Samuel Bennett","Multiplication");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment math1 = new MathAssignment("Roberto Rodriguez","Fraction","Section 7.3", "Problems 8-19");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());

        WritingAssignment writing1 = new WritingAssignment("Mary Water","European History","The Causes of World War II");
        Console.WriteLine(writing1.GetSummary());
        Console.WriteLine(writing1.GetWrtingInformation());
    }
}