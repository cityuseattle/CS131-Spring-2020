using System;

namespace NumericOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 20;
            int num2 = 77;
            float num3 = 5.2f;

            float sum = num1 + num2 + num3;
            int subtract = num2 - num1;
            int multiply = num1 * num2;
            float divide = num1 / num3;
            int modulus = num2 % num1;

            Console.WriteLine("Sum of 3 numbers is; " + sum);
            Console.WriteLine("77 - 20 is; " + subtract);
            Console.WriteLine("20 * 77 is " + multiply);
            Console.WriteLine("20 / 5.2 is " + divide);
            Console.WriteLine("77 % 20 is " + modulus);

            // All of the math is already done in lines 13-17.
            // The Writelines are simply me typing the equations that are
            // being done in lines 13-17 and then adding in the Varibale name
            // that matches the equation I've writtenI in the parentheses.
        }
    }
}