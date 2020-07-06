using System;

namespace BinaryOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 20;

            //a += b;
            //a -= b;
            //a *= b;
            //a /= b;
            a %= b;
            Console.WriteLine("The value of a is now: {0}", a);
        }
    }
}
