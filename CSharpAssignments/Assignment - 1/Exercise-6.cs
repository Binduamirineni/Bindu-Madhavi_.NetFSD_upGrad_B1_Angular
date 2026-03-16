using System;
using System.Collections.Generic;
using System.Text;
//calculating the area of rectangle and square separately.
namespace Assignment_1
{
    internal class Exercise6
    {
        static void Main()
        {
            Console.WriteLine("Enter length of Rectange");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter width of Rectange");
            int width = int.Parse(Console.ReadLine());

            int Area = length * width;
            Console.WriteLine("Area of Rectangle: " + Area);

            Console.WriteLine("Enter sides of square");
            int sides = int.Parse(Console.ReadLine());

            int sqaureArea = sides * sides;
            Console.WriteLine("Area of sqaure" + sqaureArea);
        }
    }
}