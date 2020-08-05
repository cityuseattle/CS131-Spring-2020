using System;

/********
**
** Name: Cesar, Eugenio
** Class: CS 132
** Project: Numeric Operators
** Date: 2020-07-29
** Description: Operator Routines
**
********/


namespace NumericOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 20; //initializing num1 to 20
            int num2 = 77; //initializing num2 to 77
            float num3 = 5.2f; //initializing num3 to 5.2

            float sum = num1 + num2 + num3; //sum hold the result of num1 plus num2 plus num3
            int substract = num2 - num1; // substract hold the result of substract num2 minus num1
            int multiply = num1 * num2; // multiply hold the result of multiply num1 by num2
            float divide = num1 / num3; // divide hold the result of num1 divided by num3
            int module = num2 % num1; // module hold the rest of the dividing num2 by num1


            Console.WriteLine("Sum of 3 numbers is: " + sum); //print of num1 plus num2 plus num3
            Console.WriteLine("77 - 20 is: " + substract); //print of substract num2 minus num1
            Console.WriteLine("20 * 77 is: " + multiply); //print of multiply num1 by num2
            Console.WriteLine("20 / 5.2 is: " + divide); //print of divide num1 by num2
            Console.WriteLine("77 % 20 is: " + module); //print of the rest of the dividing num2 by num1
        }
    }
}
