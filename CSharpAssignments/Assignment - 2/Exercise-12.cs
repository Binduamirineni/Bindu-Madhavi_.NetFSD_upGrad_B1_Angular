using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    internal class Ex12
    {
        static void Main()
        {
            Console.WriteLine("Enter the num1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the num2");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("7 Divisible numbers are: ");
            for (int i = num1; i <= num2; i++)
            {
                if (i % 7 == 0)
                {
                    Console.Write(i);
                }
            }

        }
    }
}