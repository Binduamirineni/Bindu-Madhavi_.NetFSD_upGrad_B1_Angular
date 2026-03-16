using System;
using System.Collections.Generic;
using System.Text;
//two numbers and display the highest number among two.
namespace Assignment_1
{
    internal class Exercise5
    {
        static void Main()
        {
            Console.WriteLine("Enter num1");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter num2");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine(num1 + " is the highest");
            }
            else
            {
                Console.WriteLine(num2 + " is the highest");
            }



        }
    }
}