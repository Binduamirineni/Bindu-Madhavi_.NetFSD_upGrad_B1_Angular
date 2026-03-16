using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    internal class Ex3
    {
        static void Main()
        {
            Console.WriteLine("Enter the first Number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second Number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("==================================");
            for (int i = num1; i < num2; i++)
            {
                Console.WriteLine(i + " ");
            }
        }
    }
}