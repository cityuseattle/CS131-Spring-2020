using System;

namespace NumericOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 20;                               //num is an integer variable with value 20. 
            int num2 = 77;                               //num2 is an interger variable with value 77.  
            float num3 = 5.2F;                           //num3 is a float variable with value 5.2.

            float sum = num1 + num2 + num3;    //Doing addition of num1, num2 and num3 variable and assining it's value to float variable sum.
            int subtract = num2 - num1;       // Subtracting value of variable num1 from num2 and assinging result to integer variable subtract.
            int multiply = num1 * num2;      // Multiplying value of variable num1 and num2 and assigning result to multiply variable.
            float divide = num1 / num3;     // Dividing value of varaible1 num from float variable num2 and assigning result to float variable divide.
            int modulus = num2 % num1;     // finding remainder of num2 to num1 using modulus operator and assigning result to modulus variable.

            Console.WriteLine("Sum of 3 numbers is: " + sum); //Printing value of variable sum
            Console.WriteLine("77 - 20 is: " + subtract); //Printing value of variable subtract.
            Console.WriteLine("20 * 77 is: " + multiply); //Printing value of variable multiply.
            Console.WriteLine("20 / 5.2 is: " + divide);  //Printing value of variable divide.
            Console.WriteLine("77 % 20 is: " + modulus); //Printing value of variable modulus.
        }
    }
}
