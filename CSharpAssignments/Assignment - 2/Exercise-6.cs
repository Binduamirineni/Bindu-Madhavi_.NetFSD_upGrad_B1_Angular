using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    internal class Ex6
    {
        static void Main()
        {
            Console.WriteLine("Enter the temparature in Farenheat");
            double temp = double.Parse(Console.ReadLine());

            double celsum = (temp - 32) * 5 / 9;

            Console.WriteLine("Temparature in Celsius: " + celsum);
        }
    }
}