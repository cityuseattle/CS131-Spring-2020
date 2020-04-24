using System;

namespace YiBinaryOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare the variables
            int a = 100;
            int b = 20;
            
            //Conduct the binaries and Write the Solutions
            
            //Addition
            a += b;
            Console.WriteLine("the value of a is now:{0}", a);
            
            //Subtraction
            a -= b;
            Console.WriteLine("the value of a is now:{0}", a);
            
            //Multiplication
            a *= b;
            Console.WriteLine("the value of a is now:{0}", a);
            
            //Division
            a /= b;
            Console.WriteLine("the value of a is now:{0}", a);
            
            //Remainder
            a %= b;
            Console.WriteLine("the value of a is now:{0}", a);


        }
    }
}