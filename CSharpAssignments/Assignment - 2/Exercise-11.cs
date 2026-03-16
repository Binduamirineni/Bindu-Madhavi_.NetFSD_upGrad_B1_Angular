using System;
using System.Collections.Generic;
using System.Text;
//find the multiplication table of the given number till 20.
namespace Assignment2
{
    internal class Ex11
    {
        static void Main()
        {
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(num + " X" + i + " =" + num * i);
            }

        }
    }
}