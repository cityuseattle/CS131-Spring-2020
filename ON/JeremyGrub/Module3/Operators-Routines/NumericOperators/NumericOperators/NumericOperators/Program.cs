using System;

namespace NumericOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 20; 
            int num2 = 77;
            float num3 = 5.2f; //f - suffix is needed to declare the 5.2 as a float 

            float sum = num1 + num2 + num3; //this adds all variables together (float)
            int subtract = num2 - num1;  // this subtracts num1 from num2 (int)
            int multiply = num1 * num2; //multiplies num1 and num2 (int)
            float divide = num1 / num3; //divedes (float)
            int modulus = num2 % num1; // modulus (remainder of) (int)

            Console.WriteLine("Sunm of 3 numbers is: " + sum);   //these are all the outputs 
            Console.WriteLine("77 - 20 is: " + subtract);
            Console.WriteLine("20 * 77 is: " + multiply);
            Console.WriteLine("20 / 5.2 is: " + divide);
            Console.WriteLine("77 % 20 is: " + modulus);
        }
    }
}
