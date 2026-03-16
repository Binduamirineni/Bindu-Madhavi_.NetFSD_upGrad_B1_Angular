using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    internal class Exercise2
    {
        // 1KM = 1000M
        static void Main()
        {
            Console.WriteLine("Enter Distance in KM");
            int km = Convert.ToInt32(Console.ReadLine());

            int res = km * 1000;
            Console.WriteLine(km + "km distance in meters is: " + res);


        }
    }
}