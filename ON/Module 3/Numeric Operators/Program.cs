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

            // this is simply the addition of three variables with interger values
            Console.WriteLine("Sum of 3 numbers is: " + sum);
            // this is showing the result of subtracting num1 from num2
            Console.WriteLine("77 - 20 is: " + subtract);
            // this the product of num1 and num2
            Console.WriteLine("20 * 77 is: " + multiply);
            // this is the quotient of num1 and num2
            Console.WriteLine("20 / 5.2 is: " + divide);
            // this is the remainder of num1 and num2
            Console.WriteLine("77 % 20 is: " + modulus);
        }
    }
}
