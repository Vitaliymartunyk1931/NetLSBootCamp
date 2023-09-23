using CustomerWork;
using CustomerWork_V2;
using System;
using System.Collections.Generic;
using System.Collections.Generic;

namespace CustomerWork
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer
            {
                CustomerId = 1,
                Name = "Vitaliy Martunyk",
                Email = "martunykvitaliy@gmail.com",
            };

            var laptop1 = new Item(1, "ASUS TUF XF-506", "24000.0", new ItemSize(5.5, 7.0, 1.0));

            var laptop2 = new Item(2, "Acer Nitro 5", "20000.0", new ItemSize(3.0, 5.0, 0.7));

            var order = new Order(1, customer, new List<Item> { laptop1, laptop2 });

            Console.WriteLine($"Customer is: {order.Customer.Name}");
            Console.WriteLine("Goods on order: ");
            foreach (var item in order.Items)
            {
                Console.WriteLine($"{item.Name}, Width: {item.Size.Width}x{item.Size.Height}x{item.Size.Depth}, Price: {item.Price}");
            }

            double totalItemsCost = order.CalculateTotalCost();
            double totalOrderCost = order.CalculateTotalCost();
            Console.WriteLine($"Total cost of the order: {totalOrderCost}");

            Console.WriteLine($"Total cost of items: {totalItemsCost}");
        }
    }
}
