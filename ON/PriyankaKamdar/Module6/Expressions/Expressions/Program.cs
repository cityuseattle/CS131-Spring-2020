using System;

namespace Expressions
{
    class Program
    {
      public static void Main(string[] args)
        { 
            int a = Convert.ToInt32(Console.ReadLine());    // Converting the user input string to integer and assigning to variable a 
            int b = Convert.ToInt32(Console.ReadLine());    // Converting the user input string to integer and assigning to variable b
            // If we do not convert the user input string to integer then it would give compilation error.
            Console.WriteLine("Sum: {0} + {1} = {2}", a, b, a + b);
            Console.WriteLine("Subtract: {0} - {1} = {2}", a, b, a - b);
            Console.WriteLine("Multiply: {0} * {1} = {2}", a, b, a * b);
            Console.WriteLine("Divide: {0} / {1} = {2}", a, b, a / b);
            Console.WriteLine("Remainder: {0} % {1} = {2}", a, b, a % b);
        }
    }
}
