using System;

namespace NumericOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 20; // I have created an integer variable called num1 and assigned the value of 20 into it
            int num2 = 77; // I have created an integer variable called num2 and assigned the value of 77 into it
            float num3 = 5.2f; // I have created an integer variable called num1 and assigned the value of 20 into it

            float sum = num1 + num2 + num3; //  I have created a float variable type called "sum" and I'm assigning the value of the sum of num1, num2 and num3. The variable type is float because num3 is a decimal numerical value
            int subtract = num2 - num1; // I have created an int variable called "subtract" and I'm assigning the value of calculated result of num2 minus num1 into "subtract"
            int multiply = num1 * num2; // I have created an int variable called "multiply" and I'm assigning the value of calculated result of num1 multiplied by num2 into "multiply"
            float divide = num1 / num3; // I have created a float variable called "divide" and I'm assigning the value of calculated result of num1 divided by num3 which will give me a decimal value that can't be assigned into an int type
            int modulus = num2 % num1; // I have created an int variable called "modulus" and I'm assigning the value of calculated result of num2 modulus num1 which creates a remainder value of 17 (i.e. 77/20 = 60 remainder 17)

            Console.WriteLine("Sum of 3 numbers is: " + sum); // This displays the value of the sum variable which is 102.2
            Console.WriteLine("77 - 20 is: " + subtract); // This displays the value of the subtract variable which is 57
            Console.WriteLine("20 * 77 is: " + multiply);// This displays the value of the multiply variable which is 1540
            Console.WriteLine("20 / 5.2 is: " + divide);// This displays the value of the divide variable which is 3.846154
            Console.WriteLine("77 % 20 is: " + modulus); // This displays the value of the subtract variable which is 17

        }
    }
}
