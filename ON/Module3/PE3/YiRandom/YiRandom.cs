using System;
using System.Security.Cryptography;

namespace YiRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create the Random
            Random rand = new Random();
            
            //Declare the Variables
            int a = rand.Next(101);
            int b = rand.Next(101);
           
            //Doing the Math
            int sum = a + b;
            int dif = a - b;
            int prod = a * b;
            float quot = (float)a / (float)b; //Casted Float to show answer that wasn't a 0
            int remain = a % b;
            
            //Writing the answers
            Console.WriteLine("a is: " + a);
            Console.WriteLine("b is: " + b);
            Console.WriteLine("The sum of a and b is " + sum);
            Console.WriteLine("The difference of a and b is: " + dif);
            Console.WriteLine("The product of a and b is: " + prod);
            Console.WriteLine("The quotient of a and b is: " + quot);
            Console.WriteLine("The remainder of a and b is: " + remain);

        }
    }
}