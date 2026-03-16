using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    internal class Ex15
    {
        static void Main()
        {
            Console.WriteLine("Enter the Word");

            String name = Console.ReadLine();

            //length
            Console.WriteLine("Length of the word is: " + name.Length);

            // reverse
            Console.WriteLine("Length of the word is: " + name.Reverse);

            Console.WriteLine("Enter the Name1");

            String name1 = Console.ReadLine();

            Console.WriteLine("Enter the Name2");

            String name2 = Console.ReadLine();

            name1 = name1.ToLower();
            name2 = name2.ToLower();

            if (name1 == name2)
            {
                Console.WriteLine(name1 + " and " + name2 + " Both are same");
            }
            else
            {
                Console.WriteLine(name1 + " and " + name2 + " Both not are same");
            }

        }
    }
}