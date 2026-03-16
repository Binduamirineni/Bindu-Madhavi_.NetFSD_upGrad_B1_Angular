using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    internal class Ex7
    {
        static void Main()
        {
            double total = 0;
            Console.Write("Enter product number (1-3): ");
            int productNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter quantity sold: ");
            int quantity = Convert.ToInt32(Console.ReadLine());


            switch (productNumber)
            {
                case 1:
                    total = quantity * 22.5;
                    break;

                case 2:
                    total = quantity * 44.50;
                    break;

                case 3:
                    total = quantity * 9.98;
                    break;

                default:
                    Console.WriteLine("Invalid product number");
                    return;
            }

            Console.WriteLine("Total retail value: " + total);

        }
    }
}