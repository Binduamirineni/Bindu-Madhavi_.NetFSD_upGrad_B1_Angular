using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQOrdersCustomers
{
    // Customer Class
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    // Order Class
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public double Amount { get; set; }

        public Order(int id, int custId, double amount)
        {
            Id = id;
            CustomerId = custId;
            Amount = amount;
        }
    }

    class Program
    {
        static void Main()
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer(1, "Ravi"),
                new Customer(2, "Anita"),
                new Customer(3, "Kiran"),
                new Customer(4, "Sneha")
            };

            List<Order> orders = new List<Order>()
            {
                new Order(101, 1, 3000),
                new Order(102, 1, 2500),
                new Order(103, 2, 2000),
                new Order(104, 3, 6000)
            };

            // 1. Join Customers and Orders
            Console.WriteLine("---- Customer Orders ----");
            var joinData = customers.Join(
                orders,
                c => c.Id,
                o => o.CustomerId,
                (c, o) => new { c.Name, o.Amount }
            );

            foreach (var item in joinData)
            {
                Console.WriteLine($"{item.Name} - {item.Amount}");
            }

            // 2. Total order amount per customer
            Console.WriteLine("\n---- Total Order Amount per Customer ----");
            var totalPerCustomer = orders
                .GroupBy(o => o.CustomerId)
                .Select(g => new
                {
                    CustomerId = g.Key,
                    Total = g.Sum(o => o.Amount)
                });

            foreach (var t in totalPerCustomer)
            {
                string name = customers.First(c => c.Id == t.CustomerId).Name;
                Console.WriteLine($"{name} - {t.Total}");
            }

            // 3. Customers with total orders > 5000
            Console.WriteLine("\n---- Customers with Total > 5000 ----");
            var highCustomers = totalPerCustomer.Where(t => t.Total > 5000);

            foreach (var t in highCustomers)
            {
                string name = customers.First(c => c.Id == t.CustomerId).Name;
                Console.WriteLine($"{name} - {t.Total}");
            }

            // 4. Customers with NO orders (Left Join)
            Console.WriteLine("\n---- Customers with No Orders ----");
            var noOrders = customers
                .GroupJoin(
                    orders,
                    c => c.Id,
                    o => o.CustomerId,
                    (c, o) => new { Customer = c, Orders = o }
                )
                .Where(x => !x.Orders.Any());

            foreach (var item in noOrders)
            {
                Console.WriteLine(item.Customer.Name);
            }
        }
    }
}