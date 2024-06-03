using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("127 Dream St", "NCity", "CA", "USA");
        Address address2 = new Address("Caratland St.", "Seoul", "Gyeonggi", "Korea");
        Address address3 = new Address("Nissan Stadium", "Yokohama", "Kanagawa", "Japan");

        Lecture lecture = new Lecture("SVT Talk","SVT Conference","1/1/2024","9:00am",address1,"SEVENTEEN",100);
        Console.WriteLine();
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine("==================================================");

        Console.WriteLine();
        Reception reception = new Reception("2024 Caratland","SVT Fanmeeting","7/17/2024","6:00pm",address2,"carat@svt.com");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine("==================================================");
        
        Console.WriteLine();
        Outdoor outdoor = new Outdoor("SVT Follow Again","SVT Concert","5/26/2024","5:00pm",address3,"Cloudy");
        Console.WriteLine(outdoor.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoor.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoor.GetShortDescription());
    }
}