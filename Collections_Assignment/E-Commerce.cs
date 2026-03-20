using System;
using System.Collections.Generic;
using System.Linq;

namespace EcommerceCatalog
{
    // Product Class
    public class Product
    {
        // Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }

        // Constructor
        public Product(int id, string name, double price, string category)
        {
            Id = id;
            Name = name;
            Price = price;
            Category = category;
        }
    }

    class Program
    {
        static void Main()
        {
            // List of Products
            List<Product> products = new List<Product>()
            {
                new Product(1, "Laptop", 50000, "Electronics"),
                new Product(2, "Mobile", 20000, "Electronics"),
                new Product(3, "Headphones", 1500, "Electronics"),
                new Product(4, "Shoes", 1200, "Fashion"),
                new Product(5, "Watch", 3000, "Fashion"),
                new Product(6, "Bag", 800, "Fashion"),
                new Product(7, "Tablet", 25000, "Electronics"),
                new Product(8, "Keyboard", 700, "Electronics"),
                new Product(9, "Chair", 1800, "Furniture"),
                new Product(10, "Table", 3500, "Furniture")
            };

            // Display all products
            Console.WriteLine("---- All Products ----");
            Display(products);

            // Price > 1000
            Console.WriteLine("\n---- Products with Price > 1000 ----");
            var expensive = products.Where(p => p.Price > 1000);
            Display(expensive.ToList());

            // Sort Ascending
            Console.WriteLine("\n---- Sorted by Price (Ascending) ----");
            var asc = products.OrderBy(p => p.Price).ToList();
            Display(asc);

            // Sort Descending
            Console.WriteLine("\n---- Sorted by Price (Descending) ----");
            var desc = products.OrderByDescending(p => p.Price).ToList();
            Display(desc);

            // Remove product by Id
            Console.WriteLine("\n---- Remove Product with Id = 5 ----");
            Product removeProduct = products.FirstOrDefault(p => p.Id == 5);
            if (removeProduct != null)
            {
                products.Remove(removeProduct);
                Console.WriteLine("Product removed successfully!");
            }

            Console.WriteLine("\n---- After Removal ----");
            Display(products);

            // Bonus: Filter by Category (LINQ)
            Console.WriteLine("\n---- Electronics Products ----");
            var electronics = products.Where(p => p.Category == "Electronics");
            Display(electronics.ToList());
        }

        // Method to display products
        static void Display(List<Product> products)
        {
            foreach (var p in products)
            {
                Console.WriteLine($"Id: {p.Id}, Name: {p.Name}, Price: {p.Price}, Category: {p.Category}");
            }
        }
    }
}