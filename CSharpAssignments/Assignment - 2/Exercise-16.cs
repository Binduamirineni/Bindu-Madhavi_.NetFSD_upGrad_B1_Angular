using System;
using System.Collections.Generic;
using System.Text;
// Palindrom string
namespace Assignment2
{
    internal class Ex16
    {
        static void Main()
        {
            Console.WriteLine("Enter the Name");

            String name = Console.ReadLine();

            name = name.ToLower();

            bool isPalin = true;

            int start = 0;
            int end = name.Length - 1;
            while (start < end)
            {
                if (name[start] != name[end])
                {
                    isPalin = false;
                    break;
                }

                start++;
                end--;
            }

            if (isPalin)
                Console.WriteLine("It is a Palindrome String");
            else
                Console.WriteLine("It is not a Palindrome String");


        }
    }
}