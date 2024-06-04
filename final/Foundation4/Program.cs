using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities= new List<Activity>();

        Running running = new Running("23 May 2023",90, 3);
        activities.Add(running);

        Cycling cycling = new Cycling("04 May 2023",60, 15.00);
        activities.Add(cycling);

        Swimming swimming = new Swimming("05 May 2023",20, 5);
        activities.Add(swimming);

        foreach(Activity activity in activities)
       {
            string details = activity.GetSummary();

            Console.WriteLine($"{details}");

       }


    }
}