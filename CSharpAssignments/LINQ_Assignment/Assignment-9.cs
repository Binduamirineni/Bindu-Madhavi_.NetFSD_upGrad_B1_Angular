using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQECommerce
{
    // Order Class
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalAmount { get; set; }

        // Constructor
        public Order(int id, string customer, DateTime date, double amount)
        {
            Id = id;
            CustomerName = customer;
            OrderDate = date;
            TotalAmount = amount;
        }
    }

    class Program
    {
        static void Main()
        {
            List<Order> orders = new List<Order>()
            {
                new Order(1, "Ravi", DateTime.Now.AddDays(-10), 5000),
                new Order(2, "Anita", DateTime.Now.AddDays(-40), 3000),
                new Order(3, "Ravi", DateTime.Now.AddDays(-5), 7000),
                new Order(4, "Kiran", DateTime.Now.AddDays(-20), 2000),
                new Order(5, "Sneha", DateTime.Now.AddDays(-15), 8000),
                new Order(6, "Anita", DateTime.Now.AddDays(-2), 6000),
                new Order(7, "Kiran", DateTime.Now.AddDays(-60), 4000)
            };

            // 1. Orders in last 30 days
            Console.WriteLine("---- Orders in Last 30 Days ----");
            var recentOrders = orders
                .Where(o => o.OrderDate >= DateTime.Now.AddDays(-30));

            foreach (var o in recentOrders)
            {
                Console.WriteLine($"{o.CustomerName} - {o.TotalAmount} - {o.OrderDate}");
            }

            // 2. Monthly Sales Report
            Console.WriteLine("\n---- Monthly Sales Report ----");
            var monthlySales = orders
                .GroupBy(o => new { o.OrderDate.Year, o.OrderDate.Month })
                .Select(g => new
                {
                    Month = $"{g.Key.Month}/{g.Key.Year}",
                    TotalSales = g.Sum(o => o.TotalAmount)
                });

            foreach (var m in monthlySales)
            {
                Console.WriteLine($"{m.Month} - {m.TotalSales}");
            }

            // 3. Top 5 Customers by Spending
            Console.WriteLine("\n---- Top 5 Customers ----");
            var topCustomers = orders
                .GroupBy(o => o.CustomerName)
                .Select(g => new
                {
                    Customer = g.Key,
                    TotalSpent = g.Sum(o => o.TotalAmount)
                })
                .OrderByDescending(c => c.TotalSpent)
                .Take(5);

            foreach (var c in topCustomers)
            {
                Console.WriteLine($"{c.Customer} - {c.TotalSpent}");
            }

            // 4. Highest Order per Month
            Console.WriteLine("\n---- Highest Order per Month ----");
            var highestPerMonth = orders
                .GroupBy(o => new { o.OrderDate.Year, o.OrderDate.Month })
                .Select(g => new
                {
                    Month = $"{g.Key.Month}/{g.Key.Year}",
                    MaxOrder = g.Max(o => o.TotalAmount)
                });

            foreach (var h in highestPerMonth)
            {
                Console.WriteLine($"{h.Month} - {h.MaxOrder}");
            }
        }
    }
}