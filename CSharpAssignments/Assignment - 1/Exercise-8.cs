using System;
using System.Collections.Generic;
using System.Text;
//accepting third character of the given string and then display whether it is vowel or constant
namespace Assignment_1
{
    internal class Exercise8
    {
        static void Main()
        {
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();

            char ch = str[2];

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' ||
                ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("The third character '" + ch + "' is a Vowel");
            }
            else
            {
                Console.WriteLine("The third character '" + ch + "' is a Consonant");
            }


        }
    }
}