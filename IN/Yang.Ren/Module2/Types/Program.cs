using Microsoft.VisualBasic.CompilerServices;
using System;

namespace Types
{
    class Program
    {
        static void Main(string[] args)
        {
            int Integer = 77;
            double number = 22.25;
            string String = "Value 100";
            int i;
            i = (int)number;

            Console.WriteLine(i); // Directly obtaining integer part of double value
            Console.WriteLine(Integer);
            Console.WriteLine(number);
            Console.WriteLine(String);
        }
    }
}
