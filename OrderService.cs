using System.Collections.Generic;
using System.Linq;

namespace SieMarket
{
    public class OrderService
    {
        public static string GetTopSpender(List<Order> orders)
        {
            var topCustomer = orders
                .GroupBy(o => o.CustomerName)
                .Select(g => new
                {
                    Customer = g.Key,
                    TotalSpent = g.Sum(o => o.CalculateFinalPrice())
                })
                .OrderByDescending(x => x.TotalSpent)
                .FirstOrDefault();

            return topCustomer?.Customer;
        }

        public static List<(string ProductName, int TotalQuantity)> GetPopularProducts(List<Order> orders)
        {
            return orders
                .SelectMany(o => o.Items)
                .GroupBy(i => i.ProductName)
                .Select(g => (ProductName: g.Key, TotalQuantity: g.Sum(i => i.Quantity)))
                .OrderByDescending(x => x.TotalQuantity)
                .ToList();
        }
    }
}
