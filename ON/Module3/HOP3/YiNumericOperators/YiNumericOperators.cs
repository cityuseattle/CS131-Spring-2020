using System;

namespace YiNumericOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare the Variables
            int num1 = 20;
            int num2 = 77;
            float num3 = 5.2f;

            //Calculating sums and other mathematics
            float sum = num1 + num2 + num3;
            int subtract = num2 - num1;
            int multiply = num1 * num2;
            float divide = num1 / num3;
            int modulus = num2 % num1;
            
            //Write out the answers
            Console.WriteLine("Sum of the 3 numbers is: " + sum);
            Console.WriteLine("77 - 20 is: " + subtract);
            Console.WriteLine("20 * 77 is: " + multiply);
            Console.WriteLine("20 / 5.2 is: " + divide);
            Console.WriteLine("77 % 20 is: " + modulus);

        }
    }
}