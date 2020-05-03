using System;

namespace BinaryOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 4;

            Console.WriteLine("The value of a is now:{0}", a, b); a +=b;

            Console.WriteLine("The value of a is now:{0}", a, b); a *=b;

            Console.WriteLine("The value of a is now:{0}", a, b); a /=b;

            Console.WriteLine("The value of a is now:{0}", a, b); a -=b;
        }
    }
}
