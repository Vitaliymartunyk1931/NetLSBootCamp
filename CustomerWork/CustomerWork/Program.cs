using CustomerWork;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var customer = new Customer()
        {
            CustomerId = 1,
            Name = "Vitaliy Martunyk",
            Email = "martunykvitaliy@gmail.com",
        };

        double Width;
        double Heigth;
        double Depth;

        var laptop1 = new Item
        {
            ItemId = 1,
            Name = "ASUS TUF XF-506: ",
            Price = 24000.0,
            Size = new ItemSize(Width = 5.5, Heigth = 7.0, Depth = 1.0)
        };

        var laptop2 = new Item
        {
            ItemId = 1,
            Name = "Acer Nitro 5: ",
            Price = 20000.0,
            Size = new ItemSize(Width = 3.0, Heigth = 5.0, Depth = 0.7)
        };

        var order = new Order
        {
            OrderId = 1,
            Customer = customer,
            Items = new List<Item> { laptop1, laptop2 }
        };

        Console.WriteLine($"Customer is: {order.Customer.Name}");
        Console.WriteLine("Goods on order: ");
        foreach (var item in order.Items) 
        {
            Console.WriteLine($"{item.Name}, Width: {item.Size.Width}x{item.Size.Height}x{item.Size.Depth}, Price: {item.Price}");
        }
        Console.WriteLine($"Total cost of the order: {order.TotalPrice}");
    }
}