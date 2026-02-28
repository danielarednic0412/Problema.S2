using System;
using System.Collections.Generic;
using SieMarket;

class Program
{
    static void Main()
    {
        var orders = new List<Order>();

        var order1 = new Order("Alice");
        order1.AddItem(new OrderItem("Laptop", 1, 800));
        order1.AddItem(new OrderItem("Mouse", 2, 25));
        orders.Add(order1);

        var order2 = new Order("Bob");
        order2.AddItem(new OrderItem("Keyboard", 1, 100));
        orders.Add(order2);

        var order3 = new Order("Alice");
        order3.AddItem(new OrderItem("Monitor", 2, 300));
        orders.Add(order3);

        Console.WriteLine("Final price for each order:");
        foreach (var order in orders)
        {
            Console.WriteLine($"{order.CustomerName} - {order.CalculateFinalPrice()} EUR");
        }

        Console.WriteLine();
        Console.WriteLine("Top spender:");
        Console.WriteLine(OrderService.GetTopSpender(orders));

        Console.WriteLine();
        Console.WriteLine("Popular products:");
        var popularProducts = OrderService.GetPopularProducts(orders);
        foreach (var product in popularProducts)
        {
            Console.WriteLine($"{product.ProductName} - {product.TotalQuantity} sold");
        }
    }
}
