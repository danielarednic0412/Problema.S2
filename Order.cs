using System;
using System.Collections.Generic;
using System.Linq;

namespace SieMarket
{
    public class Order
    {
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderItem> Items { get; set; }

        public Order(string customerName)
        {
            CustomerName = customerName;
            OrderDate = DateTime.Now;
            Items = new List<OrderItem>();
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public decimal CalculateFinalPrice()
        {
            decimal total = Items.Sum(i => i.GetTotal());

            if (total > 500)
            {
                total *= 0.9m; // 10% discount
            }

            return total;
        }
    }
}
