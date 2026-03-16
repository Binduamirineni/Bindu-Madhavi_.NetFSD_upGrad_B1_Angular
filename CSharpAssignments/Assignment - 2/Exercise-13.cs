using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    internal class Ex13
    {
        static void Main()
        {
            Console.WriteLine("Enter num1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num3");
            int num3 = int.Parse(Console.ReadLine());


            //int largest = Math.Max(num1, Math.Max(num2, num3));
            if (num1 >= num2 && num2 >= num3)
            {
                Console.WriteLine("Largest number is: " + num1);
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine("Largest number is: " + num2);
            }
            else
            {
                Console.WriteLine("Largest number is: " + num3);
            }

        }
    }
}