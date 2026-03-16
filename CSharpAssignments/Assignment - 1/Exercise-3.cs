using System;
using System.Collections.Generic;
using System.Text;
//five numbers and display the sum and average of the numbers.
namespace Assignment_1
{
    internal class Exercise3
    {

        static void Main()
        {
            Console.WriteLine("Enter Num1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Num2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Num3");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Num4");
            int num4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Num5");
            int num5 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2 + num3 + num4 + num5;
            Console.WriteLine("The sum of 5 numbers is: " + sum);

            int avg = sum / 5;
            Console.WriteLine("The Average of 5 numbers is: " + avg);

        }
    }
}