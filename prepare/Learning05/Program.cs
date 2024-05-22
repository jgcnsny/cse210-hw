using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

       List<Shape> shapes = new List<Shape>();

       Square square = new Square("pink", 2);
       //Console.WriteLine(square.GetColor());
       //Console.WriteLine(square.GetArea());
       shapes.Add(square);

       Rectangle rectangle = new Rectangle("blue", 3, 2);
       //Console.WriteLine(rectangle.GetColor());
       //Console.WriteLine(rectangle.GetArea());
       shapes.Add(rectangle);

       Circle circle = new Circle("yellow", 5);
       //Console.WriteLine(circle.GetColor());
       //Console.WriteLine(circle.GetArea());
       shapes.Add(circle);

       foreach(Shape shape in shapes)
       {
            string color = shape.GetColor();

            double area = shape.GetArea();

            Console.WriteLine($"Color: {color} Area: {area}");

       }

    }
}