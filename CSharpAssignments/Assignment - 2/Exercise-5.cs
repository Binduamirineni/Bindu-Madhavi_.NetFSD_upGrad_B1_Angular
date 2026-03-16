using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    internal class Ex5
    {
        static void Main()
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());

            int evenCount = 0;
            int oddCount = 0;

            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }

            Console.WriteLine("Even Count:" + evenCount);
            Console.WriteLine("Odd Count:" + oddCount);
        }
    }
}
