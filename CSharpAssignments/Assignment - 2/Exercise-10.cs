using System;
using System.Collections.Generic;
using System.Text;
//Fibonacci series till
namespace Assignment2
{
    internal class Ex10
    {
        static void Main()
        {
            int n;
            int a = 0, b = 1, c;

            Console.WriteLine("Enter number of terms:");
            n = int.Parse(Console.ReadLine());

            Console.Write(a + " " + b + " ");

            for (int i = 2; i < n; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }

        }
    }
}