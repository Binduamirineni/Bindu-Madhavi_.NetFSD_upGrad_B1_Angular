using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQNumbers
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 5, 10, 15, 20, 25, 30 };

            // 1. Get even numbers
            Console.WriteLine("---- Even Numbers ----");
            var even = numbers.Where(n => n % 2 == 0);
            foreach (var n in even)
            {
                Console.WriteLine(n);
            }

            // 2. Numbers greater than 15
            Console.WriteLine("\n---- Numbers > 15 ----");
            var greater = numbers.Where(n => n > 15);
            foreach (var n in greater)
            {
                Console.WriteLine(n);
            }

            // 3. Square of each number
            Console.WriteLine("\n---- Squares ----");
            var squares = numbers.Select(n => n * n);
            foreach (var n in squares)
            {
                Console.WriteLine(n);
            }

            // 4. Count numbers divisible by 5
            Console.WriteLine("\n---- Count divisible by 5 ----");
            int count = numbers.Count(n => n % 5 == 0);
            Console.WriteLine(count);
        }
    }
}