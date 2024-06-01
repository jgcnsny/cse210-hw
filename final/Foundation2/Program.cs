using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("127 Dream St", "NCity", "CA", "USA");
        Customer customer1 = new Customer("Daniel Brown", address1);

        Address address2 = new Address("Caratland St.", "Seoul", "Gyeonggi", "Korea");
        Customer customer2 = new Customer("Jeon Wonwoo", address2);

        Address address3 = new Address("Salute St.", "Florence", "Tuscany", "Italy");
        Customer customer3 = new Customer("Hana Swiss", address3);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("SVT Official Light Stick V3", "SVTLSV3", 65.00, 2));
        order1.AddProduct(new Product("SVY Light Stick Deco Ring Set", "LSDECO056", 32.00, 2));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("SVT Follow Shopper Bag", "SB002", 7.5, 3));
        order2.AddProduct(new Product("SVT Ball Cap", "BC147", 5.25, 2));

        Order order3 = new Order(customer3);
        order3.AddProduct(new Product("Nana Tour Zip up Hoodie", "NNTZH789", 118.75, 1));
        order3.AddProduct(new Product("Nana Tour DK Shirt", "NNTDK456", 53.75, 2));
        order3.AddProduct(new Product("Nana Tour Sticker Pack", "NNTSP369", 13.75, 2));

        Console.WriteLine("Order1 Total Cost: $" + order1.GetTotalPrice());
        Console.WriteLine("Packing Label");
        Console.WriteLine("=========================");
        Console.WriteLine($"{order1.DisplayPackingLabel()}\n");
        Console.WriteLine("Shipping Label");
        Console.WriteLine("=========================");
        Console.WriteLine($"{order1.ShippingLabel()}\n");
        

        Console.WriteLine("Order2 Total Cost: $" + order2.GetTotalPrice());
        Console.WriteLine("Packing Label");
        Console.WriteLine("=========================");
        Console.WriteLine($"{order2.DisplayPackingLabel()}\n");
        Console.WriteLine("Shipping Label");
        Console.WriteLine("=========================");
        Console.WriteLine($"{order2.ShippingLabel()}\n");

        Console.WriteLine("Order3 Total Cost: $" + order3.GetTotalPrice());
        Console.WriteLine("Packing Label");
        Console.WriteLine("=========================");
        Console.WriteLine($"{order3.DisplayPackingLabel()}\n");
        Console.WriteLine("Shipping Label");
        Console.WriteLine("=========================");
        Console.WriteLine($"{order3.ShippingLabel()}\n");
    }
}