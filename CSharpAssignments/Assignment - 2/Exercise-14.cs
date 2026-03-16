using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Java;
using System.Text;

namespace Assignment2
{
    internal class Ex14
    {
        static void Main()
        {
            int[] marks = new int[10];

            // Accept marks
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter Marks " + (i + 1));
                marks[i] = int.Parse(Console.ReadLine());
            }

            int min = marks[0];
            int max = marks[0];
            int total = 0;

            // Calculate total, min, max
            for (int i = 0; i < 10; i++)
            {
                total += marks[i];

                if (marks[i] < min)
                    min = marks[i];

                if (marks[i] > max)
                    max = marks[i];
            }

            double avg = total / 10.0;

            Console.WriteLine("Total = " + total);
            Console.WriteLine("Average = " + avg);
            Console.WriteLine("Minimum Marks = " + min);
            Console.WriteLine("Maximum Marks = " + max);

            // Ascending order
            Array.Sort(marks);
            Console.WriteLine("Marks in Ascending Order:");
            foreach (int m in marks)
            {
                Console.Write(m + " ");
            }

            Console.WriteLine();

            // Descending order
            Array.Reverse(marks);
            Console.WriteLine("Marks in Descending Order:");
            foreach (int m in marks)
            {
                Console.Write(m + " ");
            }
        }
    }
}