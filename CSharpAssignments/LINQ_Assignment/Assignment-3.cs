using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQStringOperations
{
    class Program
    {
        static void Main()
        {
            List<string> names = new List<string> { "Ravi", "Kiran", "Amit", "Raj", "Anil" };

            // 1. Names starting with 'A'
            Console.WriteLine("---- Names starting with 'A' ----");
            var startsWithA = names.Where(n => n.StartsWith("A"));
            foreach (var name in startsWithA)
            {
                Console.WriteLine(name);
            }

            // 2. Sort alphabetically
            Console.WriteLine("\n---- Sorted Names ----");
            var sorted = names.OrderBy(n => n);
            foreach (var name in sorted)
            {
                Console.WriteLine(name);
            }

            // 3. Convert to uppercase
            Console.WriteLine("\n---- Uppercase Names ----");
            var upper = names.Select(n => n.ToUpper());
            foreach (var name in upper)
            {
                Console.WriteLine(name);
            }

            // 4. Names with length > 4
            Console.WriteLine("\n---- Names with length > 4 ----");
            var longNames = names.Where(n => n.Length > 4);
            foreach (var name in longNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}