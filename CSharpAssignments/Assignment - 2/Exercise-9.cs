using System;
using System.Collections.Generic;
using System.Text;
//factorial of the given number
namespace Assignment2
{
    internal class Ex9
    {
        static void Main()
        {
            int num;
            int fact = 1;
            Console.WriteLine("Enter Number");

            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine("Factiorial of " + num + " is: " + fact);
        }
    }
}