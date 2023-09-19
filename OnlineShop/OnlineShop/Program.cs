using System;
using Lib1;
using Lib2;

class Program
{
    static void Main()
    {
        // Створення клієнтів
        Customer customer1 = new Customer { UserId = 1, CustomerName = "Vitaliy Martunyk" };
        Customer customer2 = new Customer { UserId = 2, CustomerName = "Oleksandr Hutsenko" };

        // Створення замовлень
        OrderBase order1 = new OrderBase { OrderId = 1, Discount = 0.1m };
        OrderBase order2 = new OrderBase { OrderId = 2, Discount = 0.2m };

        // Створення товарів
        ItemBase item1 = new ItemBase { ItemId = 1, Discount = 0.05m };
        ItemBase item2 = new ItemBase { ItemId = 2, Discount = 0.1m };

        // Виведення інформації
        Console.WriteLine($"{customer1.CustomerName} has an order with a {order1.Discount * 100}% discount.");
        Console.WriteLine($"{customer2.CustomerName} has an order with a {order2.Discount * 100}% discount.");
        Console.WriteLine($"ASUS TUF XF-506 has a discount of {item1.Discount * 100}%.");
        Console.WriteLine($"ASUS ROG Phone 5S 2 has a discount of {item2.Discount * 100}%.");
    }
}
