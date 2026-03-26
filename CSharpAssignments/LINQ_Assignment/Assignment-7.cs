using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQProductInventory
{
    // Product Class
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        // Constructor
        public Product(int id, string name, string category, double price, int stock)
        {
            Id = id;
            Name = name;
            Category = category;
            Price = price;
            Stock = stock;
        }
    }

    class Program
    {
        static void Main()
        {
            List<Product> products = new List<Product>()
            {
                new Product(1, "Laptop", "Electronics", 80000, 5),
                new Product(2, "Mobile", "Electronics", 30000, 15),
                new Product(3, "Shirt", "Clothing", 1500, 20),
                new Product(4, "Jeans", "Clothing", 2000, 8),
                new Product(5, "TV", "Electronics", 60000, 0),
                new Product(6, "Shoes", "Footwear", 2500, 12)
            };

            // 1. Products with stock < 10
            Console.WriteLine("---- Low Stock Products ----");
            var lowStock = products.Where(p => p.Stock < 10);
            foreach (var p in lowStock)
            {
                Console.WriteLine($"{p.Name} - Stock: {p.Stock}");
            }

            // 2. Top 3 expensive products
            Console.WriteLine("\n---- Top 3 Expensive Products ----");
            var topProducts = products
                .OrderByDescending(p => p.Price)
                .Take(3);

            foreach (var p in topProducts)
            {
                Console.WriteLine($"{p.Name} - {p.Price}");
            }

            // 3. Group by Category
            Console.WriteLine("\n---- Products by Category ----");
            var groupCategory = products.GroupBy(p => p.Category);

            foreach (var group in groupCategory)
            {
                Console.WriteLine($"\nCategory: {group.Key}");
                foreach (var p in group)
                {
                    Console.WriteLine($"{p.Name} - {p.Price}");
                }
            }

            // 4. Total stock per category
            Console.WriteLine("\n---- Total Stock per Category ----");
            var stockPerCategory = products
                .GroupBy(p => p.Category)
                .Select(g => new
                {
                    Category = g.Key,
                    TotalStock = g.Sum(p => p.Stock)
                });

            foreach (var item in stockPerCategory)
            {
                Console.WriteLine($"{item.Category}: {item.TotalStock}");
            }

            // 5. Check if any product is out of stock
            Console.WriteLine("\n---- Out of Stock Check ----");
            bool anyOutOfStock = products.Any(p => p.Stock == 0);
            Console.WriteLine(anyOutOfStock ? "Some products are out of stock" : "All products are in stock");
        }
    }
}
