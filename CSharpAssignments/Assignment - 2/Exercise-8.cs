using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    internal class Ex8
    {
        static void Main()
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int sqaure = 0;
            for (int i = 0; i < num; i++)
            {
                sqaure = i * i;
                Console.WriteLine(sqaure + " ");
            }

        }
    }
}