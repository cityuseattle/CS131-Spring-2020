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

            Console.WriteLine("Sum of 3 numbers is: " + sum);
            Console.WriteLine("77 - 20 is: " + subtract);
            Console.WriteLine("20 * 77 is: " + multiply);
            Console.WriteLine("20 / 5.2 is: " + divide);
            Console.WriteLine("77 % 20 is: " + modulus);
        }
    }
}

//Code firstly gives values to two Number 1 and 2 as 20 and 77, then one floating point 5.2f (f means output in decimal format with double precision real number)
// Step 2 difinate caculate rules that sum, subtract, mutiply, divide, modules and output the results with comment in orange
// +: add up  * mutiplication / division % Take the remainder after dividing.