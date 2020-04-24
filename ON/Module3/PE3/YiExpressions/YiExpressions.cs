using System;

namespace YiExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare the Variables
            int a = 100;
            int b = 20;
            
            //Solve the solutions
            int sum = a + b;
            int difference = a - b;
            int multiplication = a * b;
            int division = a / b;
            int remainder = a % b;
            
            //Write the Solutions
            Console.WriteLine("100 + 20 = " + sum);
            Console.WriteLine("100 - 20 = " + difference);
            Console.WriteLine("100 * 20 = " + multiplication);
            Console.WriteLine("100 / 20 = " + division);
            Console.WriteLine("100 % 20 = " + remainder);
        }
    }
}