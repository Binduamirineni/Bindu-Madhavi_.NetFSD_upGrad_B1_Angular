using System;
using System.Collections.Generic;
using System.Text;
//display the whether it is odd or even.
namespace Assignment_1
{
    internal class Exercise4
    {
        static void Main()
        {
            Console.WriteLine("Enter the number:");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("It is a even");
            }
            else
            {
                Console.WriteLine("It is a odd");
            }
        }
    }
}