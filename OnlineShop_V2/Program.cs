using Lib1;
using Lib2;
using System;

class Program
{
    public static ItemBase itemToAdd { get; private set; }

    static void Main()
    {
        Customer customer1 = new Customer { UserId = 1, CustomerName = "Vitaliy Martunyk" };
        Customer customer2 = new Customer { UserId = 2, CustomerName = "Oleksandr Hutsenko" };


        Order order1 = new Order { OrderId = 1, Discount = 0.1m };
        Order order2 = new Order { OrderId = 1, Discount = 0.1m };

        Phone phone = new Phone { ItemId = 1, Discount = 0.05m, Model = "ASUS TUF XF-506" };
        Laptop laptop = new Laptop { ItemId = 2, Discount = 0.1m, Model = "ASUS ROG Phone 5S 2" };
        Headphones headphones = new Headphones { ItemId = 3, Discount = 0.15m, Model = "Sony WH-1000XM4" };
        Keyboard keyboard = new Keyboard { ItemId = 4, Discount = 0.12m, Model = "Logitech G Pro X" };
        Mouse mouse = new Mouse { ItemId = 5, Discount = 0.08m, Model = "SteelSeries Rival 600" };
        PremiumUser premiumUser = new PremiumUser { UserId = 3, UserName = "Premium User" };

        ItemBase[] itemsToAdd = { phone, laptop, headphones, keyboard, mouse };
        order1.AddItem(itemToAdd);
        order2.AddItem(itemToAdd);

        Console.WriteLine($"{customer1.CustomerName} has an order with a {order1.Discount * 100}% discount.");
        Console.WriteLine($"{customer2.CustomerName} has an order with a {order2.Discount * 100}% discount.");
        Console.WriteLine($"{phone.Model} has a discount of {phone.Discount * 100}%.");
        Console.WriteLine($"{laptop.Model} has a discount of {laptop.Discount * 100}%.");
        Console.WriteLine($"{headphones.Model} has a discount of {headphones.Discount * 100}%.");
        Console.WriteLine($"{keyboard.Model} has a discount of {keyboard.Discount * 100}%.");
        Console.WriteLine($"{mouse.Model} has a discount of {mouse.Discount * 100}%.");
        Console.WriteLine($"{premiumUser.UserName} is a premium user.");
    }
}