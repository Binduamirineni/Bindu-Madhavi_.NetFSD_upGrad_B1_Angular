using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    internal class Ex4
    {
        static void Main()
        {
            Console.WriteLine("Enter the Number");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
        }
    }
}