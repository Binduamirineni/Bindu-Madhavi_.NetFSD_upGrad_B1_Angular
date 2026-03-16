using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    internal class Exercise7
    {
        static void Main()
        {
            Console.WriteLine("Enter Distance:");
            double distance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Speed:");
            double speed = Convert.ToDouble(Console.ReadLine());

            double time = distance / speed;

            Console.WriteLine("Time taken for the journey is: " + time);

        }
    }
}